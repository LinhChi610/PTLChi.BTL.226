using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace PTLChi.BTL._226.Models
{
    public class Encrytion
    {
        [Obsolete]
        public string PassWordEncrytion(string pass)
        {
            return FormsAuthentication.HashPasswordForStoringInConfigFile(pass.Trim(), "12345");
        }

        internal object PasswordEncrytion(object password)
        {
            throw new NotImplementedException();
        }
    }
}