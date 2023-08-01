using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Intefaces
{
    public interface IAuth
    {
        User Authenticate(string uname, string pass);
    }
}
