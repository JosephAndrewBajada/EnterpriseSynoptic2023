using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }

        [StringLength(255)]
        public string FirstName { get; set; }
        [StringLength(255)]
        public string LastName { get; set; }
        [StringLength(15)]
        public string MobileNumber { get; set;}

        public byte[] Picture { get; set; }
    }



}
