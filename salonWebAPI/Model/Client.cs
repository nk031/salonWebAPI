using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace salonWebAPI.Model
{
    public class Client //created class for add client deatail
    {
        [Key]
       
        public int Id { get; set; }//foreign key for class
        public string client_Name { get; set; }// client name
        public string contact { get; set; }// client contact detail
        public string service { get; set; }//service name that client want to take
        [DataType(DataType.Date)]// this code will only show date rather than time
        public DateTime arrived_Date { get; set; }// appointment date

    }
}
