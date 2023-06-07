using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAD___PF_Hotel.Models
{
    internal class UserModel
    {
        public int Id_User { get; set; }
        public string Full_Name { get; set; }
        public string Names { get; set; }
        public string Last_Name_One { get; set; }
        public string Last_Name_Two { get; set; }
        public DateTime Date_Birth { get; set; }
        public int Payroll_No { get; set; }
        public string Email { get; set; }
        public string User_Password { get; set; }
        public int Id_Address { get; set; }
        public int Id_Phone { get; set; }
        public int User_Type { get; set; }
    }
}
