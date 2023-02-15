using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aim_training_updated
{
    class Data
    {
        private static int mode;
        private static string dif;
        
        public int Mode
        {
            get
            {
                return mode;
            }
            set
            {
                mode = value;
            }
        }


        public string Dif
        {
            set
            {
                dif = value;
            }
            get
            {
                return dif;
            }
        }
    }
}
