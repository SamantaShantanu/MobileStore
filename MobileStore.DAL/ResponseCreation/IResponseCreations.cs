using MobileStore.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileStore.DAL.ResponseCreation
{
    public interface IResponseCreations
    {
        bool RegisterUser(UserRegistration er);
        bool RegisterLogin(UserRegistration er);
    }
}
