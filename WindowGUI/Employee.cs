using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using System.Xml.Linq;

namespace WindowGUI
{
    public class Employee
    {
        public string id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public string sex{ get; set; }
        public string department { get; set; }
        public string position { get; set; }
        public DateTime date { get; set; }

        public Employee(string id, string name, string phone, string email, string address, string sex, string department, string position, DateTime date)
        {
            this.id = id;
            this.name = name;
            this.phone = phone;
            this.email = email;
            this.address = address;
            this.sex = sex;
            this.department = department;
            this.position = position;
            this.date = date;
        }

        public override string? ToString()
        {
            return $"id: {id}, name: {name}, phone: {phone}, email: {email}, address: {address}, sex: {sex}, department: {department}, position: {position}, date: {date.ToString()}"; ;
        }
    }
}
