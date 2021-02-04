using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_BDS
{
    class User
    {
        private string fullname;
        private string province;
        private string phone;

        public User( string fullname,  string province,  string phone)
        {
           
            this.fullname = fullname;
            this.province = province;
            this.phone = phone;
        }
        public string newphone(string phone)
        {
            string[] arr = phone.Split(' ');
            MessageBox.Show($"0{arr[0]}{arr[1]}");
            return $"0{arr[1]}";
        }
      
        public string Fullname { get => fullname; set => fullname = value; }
        public string Province { get => province; set => province = value; }
        public string Phone { get => phone; set => phone = value; }

        public bool checkAdress()
        {
            if (string.Compare(this.province, "Hồ Chí Minh") == 0)
            {
                return true;
            }
            return false;
        }
    }

}
