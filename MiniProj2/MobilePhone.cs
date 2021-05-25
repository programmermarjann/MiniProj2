using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProj2
{
    class MobilePhone 
    {
        [Key]
        public int PhoneId { get; set; }
        public string PhoneName { get; set; }
        public string PhoneModel { get; set; }
        public int PhonePurchaseDate { get; set; }
    }
}
