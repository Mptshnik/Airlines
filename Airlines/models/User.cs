using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines.models
{
    [Table("users")]
    public class User
    {
        [Column("ID")]
        public int ID { get; set; }

        [Column("Email")]
        public string Email { get; set; }
        [Column("Password")]
        public string Password { get; set; }
        [Column("FirstName")]
        public string FirstName { get; set; }
        [Column("LastName")]
        public string LastName { get; set; }
        [Column("Birthdate")]
        public DateTime Birthdate { get; set; }
        [Column("Active")]
        public bool Active { get; set; }
        [Column("OfficeID")]
        public int OfficeID { get; set; }
        public virtual Office Office { get; set; }
        [Column("RoleID")]
        public int RoleID { get; set; }
        public virtual Role Role { get; set; }
    }
}
