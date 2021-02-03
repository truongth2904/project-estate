using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_BDS
{
    class User
    {
        private string id;
        private string title;
        private string fullname;
        private string address;
        private string province;
        private string country;
        private string phone;

        public User(string id, string title, string fullname, string address, string province, string country, string phone)
        {
            this.id = id;
            this.title = title;
            this.fullname = fullname;
            this.address = address;
            this.province = province;
            this.country = country;
            this.phone = newphone(phone);
        }
        public string newphone(string phone)
        {
            string[] arr = phone.Split(' ');
            return $"0{arr[1]}";
        }
        public string Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public string Fullname { get => fullname; set => fullname = value; }
        public string Address { get => address; set => address = value; }
        public string Province { get => province; set => province = value; }
        public string Country { get => country; set => country = value; }
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
