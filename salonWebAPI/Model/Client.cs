using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace salonWebAPI.Model
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        public string client_Name { get; set; }
        public string contact { get; set; }
        public string service { get; set; }
        [DataType(DataType.Date)]
        public DateTime arrived_Date { get; set; }

    }
}
