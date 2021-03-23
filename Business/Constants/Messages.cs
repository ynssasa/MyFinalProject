using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi.";

        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime="Sistem bakımda.";
        public static string ProductsListed="Ürünler Listelendi";
        public static string ProductCountOfCategoryError="Kategorideki ürün sayısı 10 dan fazla olamaz";
        public static string ProductNameAlreadyExists="Bu kategoride böyle bir ürün ismi var";
        public static string CategoryLimitExceded="Kategory limiti aşıldığı için yeni ürün eklenmiyor";
        public static string AuthorizationDenied="Yetkiniz yok";
        public static string UserRegistered="Kullanıcı";
        public static string UserNotFound = "Kullanıcı hatası";
        public static string PasswordError = "Parola hatası";
        public static string SuccessfulLogin = "başarılı giriş";
        public static string UserAlreadyExists = "kullanıcı";
        public static string AccessTokenCreated = "Token oluşturuldu";
    }
}
