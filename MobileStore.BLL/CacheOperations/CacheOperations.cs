using MobileStore.Common;
using MobileStore.DAL.ResponseCreation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileStore.BLL.CacheOperations
{
    public class CacheOperations : ICacheOperations
    {
        private readonly IResponseCreations _responseCreations;
        public CacheOperations(IResponseCreations responseCreations)
        {
            _responseCreations = responseCreations;
        }
        public bool RegisterUser(UserRegistration er)
        {
            if (!string.IsNullOrEmpty(er.Email) && !string.IsNullOrEmpty(er.Password))
            {
                if (_responseCreations.RegisterUser(er))
                    return true;
                return false;
            }
            else
            {
                return false;
            }
        }
    }
}
