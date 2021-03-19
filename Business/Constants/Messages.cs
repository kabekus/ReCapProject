using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
       
        public static string AddingComplete = "Ekleme başarılı";
        public static string AddingError = "Ekleme başarısız";
        public static string DescriptionInvalid = "Açıklama geçersiz";
        public static string MaintanceTime = "Sistem Bakımda";
        public static string ListingComplete = "Listeleme tamamlandı";
        public static string DeletingComplete = "Silme tamamlandı";
        public static string UpdatingComplete = "Güncelleme tamamlandı";
        public static string DeliveryError  = "Araç henüz teslim edilmedi";
        public static string Rented = "Kiralama tamamlandı";
        public static string FeeError = "Günlük ücret giriniz";
        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string UserRegistered="Kullanıcı Kayıtlı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Giriş Başarılı";
        public static string UserAlreadyExists = "Bu Kullanıcı Var";
        public static string AccessTokenCreated = "Erişim Oluşturuldu";
    }
}

