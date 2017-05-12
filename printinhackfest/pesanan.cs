using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printinhackfest
{
    class pesanan
    {
        int ID, ID_FILE, JenisTinta, TipeCetak, Status;
        string filename;

        public int ID1
        {
            get
            {
                return ID;
            }

            set
            {
                ID = value;
            }
        }

        public int ID_FILE1
        {
            get
            {
                return ID_FILE;
            }

            set
            {
                ID_FILE = value;
            }
        }

        public int JenisTinta1
        {
            get
            {
                return JenisTinta;
            }

            set
            {
                JenisTinta = value;
            }
        }

        public int TipeCetak1
        {
            get
            {
                return TipeCetak;
            }

            set
            {
                TipeCetak = value;
            }
        }

        public int Status1
        {
            get
            {
                return Status;
            }

            set
            {
                Status = value;
            }
        }

        public string Filename
        {
            get
            {
                return filename;
            }

            set
            {
                filename = value;
            }
        }
    }
}
