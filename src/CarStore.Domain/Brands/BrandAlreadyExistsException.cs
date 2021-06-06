using System;
using System.Runtime.Serialization;
using Volo.Abp;

namespace CarStore.Brands
{
    public class BrandAlreadyExistsException : BusinessException
    {
        public BrandAlreadyExistsException(string name) : base(CarStoreDomainErrorCodes.BrandAlreadyExists)
        {
            WithData("name", name);
        }
    }
}