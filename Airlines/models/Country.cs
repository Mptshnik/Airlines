using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines.models
{
    public class Country
    {
        [Column("ID")]
        public int ID { get; set; }

        [Column("Name")]
        public string Name { get; set; }
    }
}
