using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{

    public class Employee
    {
        #region Nhom cac thuoc tinh cua Employee
        private int _id;
        private string _id_card;
        private string _name;
        private string _email;
        private string _phone;
        #endregion
        public Employee()
        {
            this._id = 1;
            this._id_card = "000";
            this._name = "Obama";
            this._email = "000@gmail.com";
            this._phone = "12345";
        }

        public Employee(int _id, string _id_card, string _name, string _email, string _phone)
        {
            this._id = _id;
            this._id_card = _id_card;
            this._name = _name;
            this._email = _email;
            Phone = _phone;
        }


        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public String Id_Card
        {
            get { return _id_card; }
            set { _id_card = value; }
        }

        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        public void PrintInfor()
        {
            string msg = $"{Id}\t{Id_Card}\t{Name}\t{Email}\t{Phone}";
            Console.WriteLine(msg);
        }

        public override string ToString()
        {
            string msg = $"{Id}\t{Id_Card}\t{Name}\t{Email}\t{Phone}";
            return msg;
        }

    }
}
