using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.BLL
{
    internal class BLLRestockManagement
    {
        private static BLLRestockManagement _instance;

        public static BLLRestockManagement Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BLLRestockManagement();
                }
                return _instance;
            }
            private set
            {

            }
        }
    }
}
