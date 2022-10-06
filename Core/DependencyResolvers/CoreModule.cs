using Autofac.Core;
using Core.CrossCuttingConcerns.Caching;
using Core.CrossCuttingConcerns.Caching.Microsoft;
using Core.Utilities.IoC;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DependencyResolvers
{
    public class CoreModule : ICoreModule
    {
        public void Load(IServiceCollection serviceCollection)
        {
            serviceCollection.AddMemoryCache();  //MemoryCacheManagerimizin duzgun çalışması için bağlılıklarını çözdük. bu hazır gelen bir metottur arkada bir ıcachemanager instatnce olusturur. ıcachemanager da hazır microsofttan gelir.
            serviceCollection.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            serviceCollection.AddSingleton<ICacheManager, MemoryCacheManager>(); //MemoryCacheManagerimizin duzgun çalışması için bağlılıklarını çözdük 
            serviceCollection.AddSingleton<Stopwatch>();
        }
    }
}

/* ornek olarak alttaki fonsyonda hazırdır ama interface olmadan direk calısır
 * serviceCollection.AddSingleton<HttpContextAccessor>();
 * 
 * kendi olusturdugumuz bir interface ye eşitlemek istediğimizde de 
 * serviceCollection.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
 * seklinde yazarız.
  */
