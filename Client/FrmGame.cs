using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;

namespace Client
{
    public partial class FrmGame : Form
    {
        public FrmGame()
        {

            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }
        private class bdata
        {
            public byte[] data = new byte[1024];
        }
        int[,] Board;
        bool flag=true;
        public int NguoiChoi = 0;
        bool DuocDanh = false;
        public bool chuphong=false;
        public int siso = 0;
        public string username = "";
        public bool mosansang = false;
        public Socket client;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (flag)
            {
                SolidBrush sb = new SolidBrush(Color.Transparent);
                Pen pen = new Pen(sb);
                Graphics g = panel1.CreateGraphics();
                int width = panel1.Width * 2;
                int height = panel1.Height * 2;
                Board = new int[height + 2, width + 2];
                for (int i = 0; i < width; i += 20)
                {
                    g.DrawLine(pen, i, 0, i, height);
                    for (int j = 0; j < height; j++)
                    {
                        Board[j, i] = 1;
                    }
                }
                for (int i = 0; i < height; i += 20)
                {
                    g.DrawLine(pen, 0, i, width, i);
                    for (int j = 0; j < width; j++)
                    {
                        Board[i, j] = 1;
                    }
                }
            }

        }
        private bool KiemTraThangThua(int x, int y)
        {
            int width = panel1.Width;
            int height = panel1.Height;
            int maxy;
            int maxx;
            int a = NguoiChoi;
            if ((y + 100) < height)
                maxy = y + 100;
            else
                maxy = height;
            if ((x + 100) < width)
                maxx = x + 100;
            else
                maxx = width;
            for (int i = ((y - 100) > 0) ? (y - 100) : 0; i < maxy; i += 20)
            {
                for (int j = ((x - 100) > 0) ? (x - 100) : 0; j < maxx; j += 20)
                {
                    //Đường Ngang
                    if (Board[i, j] == a && Board[i, j + 20] == a && Board[i, j + 40] == a && Board[i, j + 60] == a && Board[i, j + 80] == a)
                        return true;
                    //Đường Dọc
                    if (Board[i, j] == a && Board[i + 20, j] == a && Board[i + 40, j] == a && Board[i + 60, j] == a && Board[i + 80, j] == a)
                        return true;
                    try
                    {
                        //Đường Chéo từ phải qua trái
                        if (Board[i, j] == a && Board[i + 20, j - 20] == a && Board[i + 40, j - 40] == a && Board[i + 60, j - 60] == a && Board[i + 80, j - 80] == a)
                            return true;
                    }
                    catch { }
                    try
                    {
                        //đường chéo từ trái qua phải
                        if (Board[i, j] == a && Board[i + 20, j + 20] == a && Board[i + 40, j + 40] == a && Board[i + 60, j + 60] == a && Board[i + 80, j + 80] == a)
                            return true;
                    }
                    catch { }
                }
            }
            return false;
        }
        Rectangle rect = new Rectangle();
        private Bitmap QuanO = Client.Properties.Resources.bmpHuman;
        private Bitmap QuanX = Client.Properties.Resources.bmpMachine;
        private Bitmap Thang = Client.Properties.Resources.thang;
        private Bitmap Thua = Client.Properties.Resources.thua;
        int x, y;
        private void VeQuanCoCaro(int x, int y,int nc)
        {
            SolidBrush sb = new SolidBrush(Color.Blue);
            Graphics g = panel1.CreateGraphics();
            rect = new Rectangle(x, y, 20, 20);
            g.DrawImage((nc == 2) ? QuanO : QuanX, rect);
            Board[y, x] = nc;
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            x=e.X - (e.X % 20);
            y=e.Y - (e.Y % 20);
            if (Board[y, x] != 2 && Board[y, x] != 3 && DuocDanh==true)
            {
                VeQuanCoCaro(x, y, NguoiChoi);
                DuocDanh = false;
                bdata b = new bdata();
                if (KiemTraThangThua(x, y))
                {
                    b.data = Encoding.Unicode.GetBytes("WINNER|," + NguoiChoi.ToString() + "," + x.ToString() + "," + y.ToString() + ",");
                    draw_thang();

                }
                else
                    b.data = Encoding.Unicode.GetBytes("DANHCARO|," + x.ToString() + "," + y.ToString() + "," + NguoiChoi.ToString() + ",");
                client.Send(b.data, b.data.Length, SocketFlags.None);
            }
            thoigianconlai = 30;
        }

        private void draw_thang()
        {
            rect = new Rectangle(0, 10, 413, 281);
            Graphics g = panel1.CreateGraphics();
            g.DrawImage(Thang, rect);
        }

        public void taophongmoi()
        {
            bdata b = new bdata();
            b.data = Encoding.Unicode.GetBytes("TAOPHONGMOI|" + username);
            client.Send(b.data, b.data.Length, SocketFlags.None);
            rtbcontentchat.AppendText("Tạo Phòng Thành Công");
            if (lbidphong.Text == "0")
                layidphonggame();
        }
        private void layidphonggame()
        {
            bdata b = new bdata();
            b.data = Encoding.Unicode.GetBytes("LAYIDPHONG|,");
            client.Send(b.data, b.data.Length, SocketFlags.None);
            rtbcontentchat.AppendText("\nVào Phòng Thành Công");
            
        }
        private void laydanhsachphonggame()
        {
            bdata b = new bdata();
            b.data = Encoding.Unicode.GetBytes("LAYDANHSACHPHONG|,");
            client.Send(b.data, b.data.Length, SocketFlags.None);
        }
        private void laydanhsachnguoichoi()
        {
            bdata b = new bdata();
            b.data = Encoding.Unicode.GetBytes("DANHSACHNGUOICHOI|,");
            client.Send(b.data, b.data.Length, SocketFlags.None);
        }
        private void FrmGame_Load(object sender, EventArgs e)
        { 
           // tạo 1 thread client để lắng nghe server đưa thông tin về client 2 (phòng 2 client)
            Thread thclient = new Thread(new ThreadStart(LangNgheServer));
            thclient.IsBackground = true;
            thclient.Start();
        }
        string str;
        string[] a_str;
        int recv;
        bdata bb = new bdata();
        private void LangNgheServer()
        {
            while (true)
            {   
                try
                {
                    recv=client.Receive(bb.data); // recv chứa data từ client được gửi từ client khác 
                    str = Encoding.Unicode.GetString(bb.data, 0, recv);
                    a_str = str.Split('|');
                    LangNgheServer2(a_str[0], str);
                }
                catch
                {
                    //AppendTextThongBao("Mất Kết Nối Tới Máy Chủ");
                    break;
                }
            }
        }

        int songuoichoi = 0;
        private void LangNgheServer2(string s,string str)
        {
            switch (s)
            {
                case "DANHCARO":
                    DanhCaRo(str);
                    thoigianconlai = 30;
                    break;
                case "CHATPHONG":
                    chat(str);
                    break;
                case "CHAT":
                    richTextBox1.SelectionColor = Color.Blue;
                    richTextBox1.AppendText("\n" + a_str[1] + ": ");
                    richTextBox1.SelectionColor = Color.Green;
                    richTextBox1.AppendText(a_str[2]);
                    richTextBox1.ScrollToCaret();
                    break;
                case "PHANNGUOICHOI":
                    PhanNguoiChoi(str);
                    break;
                case "WINNER":
                    Winner(str);
                    break;
                case "IDPHONGGAME":
                    Idphong(str);
                    break;
                case "NGUOICHOIMOIVAOPHONG":
                    conguoichoivaophong();
                    songuoichoi = 2;
                    DuocDanh = true;
                    break;
                case "PHONGDADAY":
                    MessageBox.Show("Phòng Đã Đầy, Vui Lòng Chọn Phòng Khác");
                    break;
                case "BANLACHUPHONG":
                    NguoiChoi = 2;
                    songuoichoi = 1;
                    rtbcontentchat.AppendText("\n" + str.Split(',')[1]);
                    draw_thang();
                    DuocDanh = false;
                    break;
                case "DANHSACHPHONGGAME":
                    danhsachphonggame(str);
                    break;
                case "DANHSACHNGUOICHOI":
                    danhsachnguoichoi(str);
                    break;
                case "CHOILAI":
                    panel1.Invalidate();
                    if (chuphong && songuoichoi == 2)
                    {
                        DuocDanh = true;
                    }
                    thoigianconlai = 30;
                    break;

            }
        }
        private void danhsachphonggame(string str)
        {
            a_str = str.Split(',');
            ltbdanhsachphonggame.Items.Clear();
            for (int i = 1; i < a_str.Length-1; i++)
            {
                if (a_str[i].Contains(textBox1.Text))
                {
                    ltbdanhsachphonggame.Items.Add("Phòng của " + a_str[i]);
                }
                
            }
        }
        private void danhsachnguoichoi(string str)
        {
            a_str = str.Split(',');
            listView2.Items.Clear();
            for (int i = 1; i < a_str.Length; i++)
            {
                listView2.Items.Add(a_str[i]);
            }

        }

        private void conguoichoivaophong()
        {
            DuocDanh = true;
            a_str = str.Split(',');
            rtbcontentchat.AppendText("\n"+a_str[1]+" đã vào phòng");
        }
        private void Idphong(string str)
        {
            lbidphong.Text = str.Split(',')[1];
        }
        private void Winner(string str)
        {
            a_str = str.Split(',');
            VeQuanCoCaro(int.Parse(a_str[2]),int.Parse(a_str[3]),int.Parse(a_str[1]));
            KiemTraThangThua(int.Parse(a_str[2]), int.Parse(a_str[3]));
            rect = new Rectangle(0, 10, 413, 281);
            Graphics g = panel1.CreateGraphics();
            g.DrawImage(Thua, rect);
            
        }
        private void DanhCaRo(string str)
        {
            a_str = str.Split(',');
            VeQuanCoCaro(int.Parse(a_str[1]), int.Parse(a_str[2]), int.Parse(a_str[3]));
            DuocDanh = true;
        }
        private void PhanNguoiChoi(string str)
        {
            a_str = str.Split(',');
            NguoiChoi = int.Parse(a_str[1]);
            if (int.Parse(a_str[1]) == 3)
                DuocDanh = false;
        }
        private void chat(string str)
        {
            rtbcontentchat.SelectionColor = Color.Blue;
            rtbcontentchat.AppendText("\n" + "[PHÒNG] "+a_str[1]+": ");
            rtbcontentchat.SelectionColor = Color.Green;
            rtbcontentchat.AppendText(a_str[2]);
            rtbcontentchat.ScrollToCaret();
            
        }


        private void rtbchat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                bdata b = new bdata();
                b.data = Encoding.Unicode.GetBytes("CHATPHONG|"+username+"|"+ rtbchat.Text.Trim());
                client.Send(b.data, b.data.Length, SocketFlags.None);
                rtbchat.Clear();
            }
        }

        private void btntaophongmoi_Click(object sender, EventArgs e)
        {
            plroom.Visible = false;
            pnlgame.Visible = true;
            chuphong = true;
            taophongmoi();
            NguoiChoi = 2;
            lbidphong.Text = username;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            client.Close();
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] data = new byte[1024];
                data = Encoding.Unicode.GetBytes("THOATKHOIPHONGGAME|," + NguoiChoi + ",");
                client.Send(data, data.Length, SocketFlags.None);
                plroom.Visible = true;
                pnlgame.Visible = false;
                chuphong = false;
                NguoiChoi = 0;
            }
            catch
            {
                client.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bdata b = new bdata();
            b.data = Encoding.Unicode.GetBytes("CHAT|" + username + "|" + richTextBox2.Text.Trim());
            client.Send(b.data, b.data.Length, SocketFlags.None);
            richTextBox2.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try {
                laydanhsachphonggame();
                laydanhsachnguoichoi();
            }
            catch { Close(); }

        }

        private void FrmGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            client.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            byte[] data = new byte[1024];
            data = Encoding.Unicode.GetBytes("CHOILAI|," + NguoiChoi + ",");
            client.Send(data, data.Length, SocketFlags.None);
        }

        int thoigianconlai = 30;
        private void timer2_Tick(object sender, EventArgs e)
        {
            label4.Text = Math.Max(thoigianconlai, 0).ToString();
            
            if (songuoichoi != 2)
                return;
            if (thoigianconlai <= 0 && !DuocDanh)
            {
                bdata b = new bdata();
                b.data = Encoding.Unicode.GetBytes("WINNER|," + NguoiChoi.ToString() + "," + x.ToString() + "," + y.ToString() + ",");
                client.Send(b.data, b.data.Length, SocketFlags.None);
                draw_thang();

            }

            thoigianconlai -= 1;
        }

        private void ltbdanhsachphonggame_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ltbdanhsachphonggame.SelectedItem is null)
            {
                return;
            }
            str = ltbdanhsachphonggame.SelectedItem.ToString();
            a_str = str.Split('(');
            str = a_str[0].Replace("Phòng của ", "").Trim();
            try
            {
                byte[] data = new byte[1024];
                data = Encoding.Unicode.GetBytes("VAOPHONGGAME|," + str + ",");
                client.Send(data, data.Length, SocketFlags.None);

                NguoiChoi = 3;
                plroom.Visible = false;
                pnlgame.Visible = true;
                chuphong = false;
                layidphonggame();
                songuoichoi = 2;
            }
            catch
            {
                client.Close();
            }
        }

     
    }
}
