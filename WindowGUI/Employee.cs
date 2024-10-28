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
        public string Id { get; set; }
        public string Name { get; set; }
        public string? Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Sex{ get; set; }
        public string Department { get; set; }
        public string Position { get; set; }
        public DateTime Date { get; set; }

        public Employee(string id, string name, string? phone, string email, string address, string sex, string department, string position, DateTime date)
        {
            this.Id = id;
            this.Name = name;
            this.Phone = phone;
            this.Email = email;
            this.Address = address;
            this.Sex = sex;
            this.Department = department;
            this.Position = position;
            this.Date = date;
        }

        public override string? ToString()
        {
            return $"id:{Id},name: {Name}, phone: {Phone}, email: {Email}, address: {Address}, sex: {Sex}, department: {Department}, position: {Position}, date: {Date.ToString()}"; ;
        }
    }
}
