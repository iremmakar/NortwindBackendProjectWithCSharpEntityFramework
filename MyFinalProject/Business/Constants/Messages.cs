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
        public static string ProductAdded = "Ürün eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";

        public static string MaintenanceTime = "";
        public static string ProductsListed = "";

        public static string ProductCountOfCategoryError = "Kategori sayısı 15 den fazla olamaz";

        public static string ProductNameAlreadyExist = "Product adı mevcut";

        public static string AuthorizationDenied ="Yetkiniz bulunmamaktadır";
    }
}
