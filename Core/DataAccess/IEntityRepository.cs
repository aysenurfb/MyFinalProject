using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Core.Entities;

namespace Core.DataAccess
{
    // benim veritabanında product ile ilgili yapacağım operasyonların şablonu - interfacesi
    //interface in kendisi default olarak public değildir fakat içine yazılan metotlar default olarak publictir.
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);   //biz her zaman tüm ürünleri listelemeyiz. belli şartları uyanları listeleriz. o sartlara uyan nesneleri getirmek için fonksyonun parantez içine tek satırlık linq kodu yazarız. interface deki fonksyonun bu linq satırını tanıması içinse parantez içine expression yazarız.
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);  
    }
}
