using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        Socket client;
        IPEndPoint ipe;
        bool daketnoi = false;

        private void btnplay_Click(object sender, EventArgs e)
        {
            string hostName = Dns.GetHostName();
            try
            {
                // trả về cho máy tính chủ với số cổng được chọn từ phạm vi số cổng đã đăng ký.
                // chứa đựng thông tin như hostname , IP address , alises for host
                //IPHostEntry ipHostEntry = Dns.GetHostEntry(hostName);

                // danh sách kiểu địa chỉ ip chứa địa chỉ IP phân giải tên máy chủ được chứa trong thuộc tính alises
               // IPAddress[] iPAddress = ipHostEntry.AddressList;

                // tạo giao thức Tcp  socket
                client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                try
                {
                    //ipe = new IPEndPoint(IPAddress.Parse(ip.ToString()), 9124);
                    // kết nối socket đến removeendpoeint (localhost server)
                    ipe = new IPEndPoint(IPAddress.Parse(txtIP.Text), 9124);
                    client.Connect(ipe);
                    daketnoi = true;
                    
                }
                catch { }
                if (!daketnoi)
                {
                    MessageBox.Show("Không tìm thấy server");
                    Application.Exit();
                }
            }
            catch 
            {
                MessageBox.Show("Không tìm thấy server");
                Application.Exit();
            }

            

                byte[] data = new byte[1024];
                data = Encoding.Unicode.GetBytes("NAMECLIENT|," + txtusername.Text + ",");
                client.Send(data, data.Length, SocketFlags.None);


                FrmGame frm = new FrmGame();
                frm.username = txtusername.Text;
                frm.client = client;
                frm.Show();
                this.Hide();
            

        }

    }
}
