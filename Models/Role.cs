using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PTLChi.BTL._226.Models
{
    public class Role
    {
        [Key]
        public string Roleid { get; set; }
        public string Rolename { get; set; }
        public virtual Role Roles { get; set; }

    }
}