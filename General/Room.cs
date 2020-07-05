using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;

namespace General
{
    public class Room
    {
        public Player _plnguoichoi1;
        public Player _plnguoichoi2;
        public Room()
        {
            siso = 0;
            plnguoichoi1 = null;
            plnguoichoi2 = null;
        }
        public string sophong { get; set; }
        public int siso { get; set; }
        public Player plnguoichoi1
        {
            get { return this._plnguoichoi1; }
            set { this._plnguoichoi1 = value; }
        }
        public Player plnguoichoi2
        {
            get { return this._plnguoichoi2; }
            set { this._plnguoichoi2 = value; }
        }
    }
}
