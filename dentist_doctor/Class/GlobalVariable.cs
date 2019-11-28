using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dentist_doctor
{
    public static class GlobalVariable
    {
        private static string User_id = "";
        public static string _User_id
        {
            get { return User_id; }
            set { User_id = value; }
        }

        private static string User_name = "";
        public static string _User_name
        {
            get { return User_name; }
            set { User_name = value; }
        }

        private static string User_role = "";
        public static string _User_role
        {
            get { return User_role; }
            set { User_role = value; }
        }

        private static string Pat_id = "";
        public static string _Pat_id
        {
            get { return Pat_id; }
            set { Pat_id = value; }
        }

        private static string Pat_name = "";
        public static string _Pat_name
        {
            get { return Pat_name; }
            set { Pat_name = value; }
        }

    }
}
