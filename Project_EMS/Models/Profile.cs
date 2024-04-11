using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_EMS.Models
{
    public class Profile
    {
        private string id;
        private string name;
        private DateTime birthday;
        private Global.gender gender;
        private string place_of_day;
        private string contract_phone;
        private string graduation_year;
        private string address;
        private string Semeter1ofgrade10;
        private string Semeter1ofgrade11;
        private string Semeter1ofgrade12;
        private Global.status status;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public DateTime Birthday { get => birthday; set => birthday = value; }
        public Global.gender Gender { get => gender; set => gender = value; }
        public string Place_of_day { get => place_of_day; set => place_of_day = value; }
        public string Contract_phone { get => contract_phone; set => contract_phone = value; }
        public string Graduation_year { get => graduation_year; set => graduation_year = value; }
        public string Address { get => address; set => address = value; }
        public string Semeter1ofgrade101 { get => Semeter1ofgrade10; set => Semeter1ofgrade10 = value; }
        public string Semeter1ofgrade111 { get => Semeter1ofgrade11; set => Semeter1ofgrade11 = value; }
        public string Semeter1ofgrade121 { get => Semeter1ofgrade12; set => Semeter1ofgrade12 = value; }
        public Global.status Status { get => status; set => status = value; }
    }
}
