﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi";

        public static string BrandNameInvalid = "Marka adı 2 harften büyük olmalıdır.";
        internal static string carAdded ="Araba eklendi";
        internal static string carUpdated="Araba güncellendi";
        internal static string carDeleted="Araba silindi";

        public static string BrandAdded = "Marka eklendi";
        internal static string AuthorizationDenied;
        internal static string AccessTokenCreated;
        internal static string UserRegistered;
        internal static Core.Entities.Concrete.User UserNotFound;
        internal static Core.Entities.Concrete.User PasswordError;
        internal static string SuccessfulLogin;
        internal static string UserAlreadyExists;
        internal static string CarImageLimitExceeded;
        internal static string Yes;

        public static string BrandDeleted { get; internal set; }
        public static string BrandNameInValid { get; internal set; }
        public static string MaintenanceTime { get; internal set; }
        public static string BrandsListed { get; internal set; }
        public static string BrandUpdated { get; internal set; }
        public static string CustomerAdded { get; internal set; }
        public static string CustomerDeleted { get; internal set; }
        public static string CarUpdated { get; internal set; }
        public static string RentalAdded { get; internal set; }
        public static string RentalDeleted { get; internal set; }
        public static string UserAdded { get; internal set; }
        public static string UserDeleted { get; internal set; }
        public static string UserUpdated { get; internal set; }
        
    }
}
