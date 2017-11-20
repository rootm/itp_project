using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_management
{
    class Mechanic
    {
        private int MechanicID;
        private String Name;
        private int contactNo;

        public int MechanicID1
        {
            get
            {
                return MechanicID;
            }

            set
            {
                MechanicID = value;
            }
        }

        public string Name1
        {
            get
            {
                return Name;
            }

            set
            {
                Name = value;
            }
        }

        public int ContactNo
        {
            get
            {
                return contactNo;
            }

            set
            {
                contactNo = value;
            }
        }
    }
}
