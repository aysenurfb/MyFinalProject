using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "ürün eklendi";
        public static string ProductNameInvalid = "ürün ismi geçersiz";
        internal static string MaintenanceTime = "sistem bakımda";
        internal static string ProductListed="ürünler listelendi";
        public static string ProductCountsOfCategoryError="Bir kategoride en fazla 10 ürün olabilir.";
        public static string SameNameError="Aynı isimde iki urun eklenemez";
        internal static string CategoryLimitExceded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor";

        public static string AuthorizationDenied = "Bu işlem için yetkiniz yoktur";
    }
}
