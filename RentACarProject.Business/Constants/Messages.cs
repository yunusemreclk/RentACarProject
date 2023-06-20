using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarProject.Business.Constants
{
  public static class Messages
    {
        public static string CarAdded = "Araç eklendi";
        public static string ColorAdded = "Renk eklendi";
        public static string BrandAdded = "Marka eklendi";
        public static string CarAddedInvalid = " Araç eklenmedi";
        public static string ColorAddedInvalid = "Renk eklenmedi";
        public static string BrandAddedInvalid = "Marka eklenmedi";

        public static string CarUpdate = "Güncelleme işleminiz gerçekleşmiştir";
        public static string CarUpdatedInvalid = " Güncelleme gerçekleştirilmedi";
        public static string CarDeleted = "Araç silindi";
        public static string CarDeletedInvalide = "Araç silinmedi";
        public static string NotFound = "Aradığınız kriterlere uygun araç nulunamadı";

        public static string BrandNameInvalid = "Marka ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string CarListed = "Araçlar listelendi";
        public static string DailyPriceListed = "Fiyatlar listelenmiştir";
        public static string BrandLimitExceded = "Marka limiti dolduğu için yeni araç eklenemiyor";
        public static string CarImagesListed = " Araç resimleri listelendi";

        public static string CarImagesLimitedExceded = "Fotoğraf adedi 5 adetten fazla olamaz";
        public static string CarImagesAdded = "Fotoğrafı eklendi";

        public static string AuthorizationDenied = "Yetkiniz yok.";

        public static string UserRegistered = "Kayıt başarılı";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Parola hatası";
        public static string SuccessfulLogin = "Giriş başarılı";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string AccessTokenCreated = "Token oluşturuldu";
    }
}

