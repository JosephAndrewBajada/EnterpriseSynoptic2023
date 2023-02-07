using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.View_Model
{
    class ContactViewModel
    {
   
        public int Id { get; set; }


        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MobileNumber { get; set; }

        public byte[] Picture { get; set; }
    }
}
