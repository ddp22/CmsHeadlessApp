using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsHeadlessApp.SupportedClass
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Root
    {
        public bool result { get; set; }
        public string details { get; set; }
        public string token { get; set; }
        public string role { get; set; }
        public User user { get; set; }
    }

    public class User
    {
        public object latitudeUser { get; set; }
        public object longitudeUser { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string gender { get; set; }
        public object content { get; set; }
        public object userTypology { get; set; }
        public object location { get; set; }
        public string id { get; set; }
        public string userName { get; set; }
        public string normalizedUserName { get; set; }
        public string email { get; set; }
        public string normalizedEmail { get; set; }
        public bool emailConfirmed { get; set; }
        public string passwordHash { get; set; }
        public string securityStamp { get; set; }
        public string concurrencyStamp { get; set; }
        public string phoneNumber { get; set; }
        public bool phoneNumberConfirmed { get; set; }
        public bool twoFactorEnabled { get; set; }
        public object lockoutEnd { get; set; }
        public bool lockoutEnabled { get; set; }
        public int accessFailedCount { get; set; }
    }

}
