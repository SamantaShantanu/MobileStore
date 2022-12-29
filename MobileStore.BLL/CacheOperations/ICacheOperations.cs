using MobileStore.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileStore.BLL.CacheOperations
{
    public interface ICacheOperations
    {
        bool RegisterUser(UserRegistration er);
    }
}
