using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines.models
{
    public class Office
    {
        [Column("ID")]
        public int ID { get; set; }

        [Column("Title")]
        public string Tilte { get; set; }
        [Column("Phone")]
        public string Phone { get; set; }
        [Column("Contact")]
        public string Contact { get; set; }
        [Column("CountryID")]
        public int CountryID { get; set; }
        public Country Country { get; set; }
    }
}
