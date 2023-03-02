using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines.models
{
    public class Session
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Column("Date")]
        public string Date { get; set; }
        [Column("LoginTime")]
        public string LoginTime { get; set; }
        [Column("LogoutTime")]
        public string LogoutTime { get; set; }
        [Column("TimeSpentOnSystem")]
        public string TimeSpentOnSystem { get; set; }
        [Column("LogoutReason")]
        public string LogoutReason { get; set; }
        [Column("UserID")]
        public int UserID { get; set; }
        public virtual User User { get; set; } 
    }
}
