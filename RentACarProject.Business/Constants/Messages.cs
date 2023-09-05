using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarProject.Business.Constants
{
  public static class Messages
    {
        //Add Fields
        public static string CarAdded = "Araç eklendi";
        public static string ColorAdded = "Renk eklendi";
        public static string BrandAdded = "Marka eklendi";
        public static string CarImagesAdded = "Araç resmi eklendi";

        //Add Invaild Fields
        public static string CarAddedInvalid = " Araç eklenmedi";
        public static string ColorAddedInvalid = "Renk eklenmedi";
        public static string BrandAddedInvalid = "Marka eklenmedi";
        public static string CarImagesAddedInvalid = "Araç resmi eklenmedi";

        //Update Fields
        public static string CarUpdate = "Güncelleme işleminiz gerçekleşdi";
        public static string CalorUpdate = "Renk güncellendi";
        public static string BrandUpdated = " Güncelleme gerçekleştirildi";
        public static string CarImageUpdate = "Araç resmi güncellendi";

        //Update Invalid Fields
        public static string CarUpdatedInvalid = " Güncelleme gerçekleştirilemedi";
        public static string CarImageUpdatedInvalid = " Resim güncelleme işlemi gerçekleştirilemedi";

        //Delete Fields
        public static string CarDeleted = "Araç silindi";
        public static string ColorDeleted = "Renk silindi";
        public static string BrandDeleted = "Marka silindi";
        public static string CarImageDeleted = "Araç resmi silindi";


        //Delete Invalid Fields
        public static string CarDeletedInvalide = "Araç silinmedi";
        public static string ColorDeletedInvalide = "Renk silinmedi";
        public static string BrandDeletedInvalide = "Marka silinmedi";
        public static string CarImageDeletedInvalide = "Araç resmi silinmedi";

        //List Fields
        public static string CarListed = "Araçlar listelendi";
        public static string ColorListed = "Renkler listelendi";
        public static string BrandsListed = "Markalar listelendi";
        public static string CarImagesListed = "Araç resimleri listelendi";
        public static string DailyPriceListed = "Fiyatlar listelendi";
        
        //Error Fields
        public static string NotFound = "Aradığınız kriterlere uygun araç nulunamadı";
        public static string BrandNameInvalid = "Marka ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
       
        public static string BrandLimitExceded = "Marka limiti dolduğu için yeni araç eklenemiyor";
        public static string CarImagesLimitedExceded = "Resim adedi 5 adetten fazla olamaz";

        //Authorization Fields
        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string UserRegistered = "Kayıt başarılı";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Parola hatası";
        public static string SuccessfulLogin = "Giriş başarılı";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string AccessTokenCreated = "Token oluşturuldu";


    }
}

