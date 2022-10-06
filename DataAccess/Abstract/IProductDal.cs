using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    // benim veritabanında product ile ilgili yapacağım operasyonların şablonu - interfacesi
    //interface in kendisi default olarak public değildir fakat içine yazılan metotlar default olarak publictir.
    public interface IProductDal:IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetails();
    }
}
