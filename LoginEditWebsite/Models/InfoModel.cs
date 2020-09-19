using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginEditWebsite.Models
{
    public class InfoModel
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public PersonModel Person { get; set; }
        public string TelNo { get; set; }
        public string CellNo { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string AddressCode { get; set; }
        public string PostalAddress1 { get; set; }
        public string PostalAddress2 { get; set; }
        public string PostalCode { get; set; }
    }
}
