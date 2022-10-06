using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Caching
{
    public interface ICacheManager
    {
        T Get<T>(string key); //cache den bir data getirmek. bu fonksyon her turlu veride calısır.
        object Get(string key); //cache den bir data getirmek. bu fonksyon her turlu veride calısır.
        void Add(string key, object value, int duration); //cache e key de verdigimiz metodu ekleme, object gelecek datayı tutar, duration da cache de kalma suresi
        bool IsAdd(string key); //key ile verilen metod cache de var mı yok mu kontrolu eger varsa ona git yoksa database den cache ye ekle seneryosu
        void Remove(string key); //verilen key li metodu cache den silme
        void RemoveByPattern(string pattern);  //içinde get olan yada içinde category olan metodları cache dan silme
    }
}
