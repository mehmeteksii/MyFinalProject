using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages //static verirsen new lemene gerek yok 
    {
        public static string ProductAdded = "Ürün eklendi";//field ama baş harfi büyük çünkü public
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime="Sistem bakımda";
        public static string ProductsListed="Ürünler listelendi";
    }
}
