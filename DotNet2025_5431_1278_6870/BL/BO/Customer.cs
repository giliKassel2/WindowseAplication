using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO;

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Adress {  get; set; }
       public string? PhoneNumber {  get; set; }
   

    public Customer(int Id, string Name, string? Address, string? PhoneNumber)
        {
            this.Id = Id;
            this.Name = Name;
            this.Adress = Address;
            this.PhoneNumber = PhoneNumber;
        }
    
 }