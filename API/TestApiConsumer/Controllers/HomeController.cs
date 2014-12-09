using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using DotNetOpenAuth.Messaging;
using DotNetOpenAuth.OAuth;
using DotNetOpenAuth.OAuth.ChannelElements;
using Microsoft.Ajax.Utilities;

namespace TestApiConsumer.Controllers
{
    public class HomeController : Controller
    {
        private static string CLIENT_Key = "key";
        private static string CLIENT_SECRET = "secret";
        private static string API_ENDPOINT = "http://localhost:4874/api/oauth/Authorize";



        public ViewResult Index()
        {
            //var client2 = new HttpClient();
            //var result = client2.PostAsJsonAsync<Consumer>(API_ENDPOINT,
            //                                              new Consumer()
            //                                              {
            //                                                  ConsumerKey = "key",
            //                                                  ConsumerSecret = "secret"
            //                                              }).Result;

            //if (result.IsSuccessStatusCode)
            //{
            //    string token = result.Content.ReadAsStringAsync().Result;
            //    Session["token"] = token;
            //}

            return View();
        }

        public ActionResult TestCallApi()
        {
            // var url = "http://localhost:4874/api/values/GetValues?token=" + UrlEncode(Session["token"].ToString());
            var url = "http://localhost:4874/api/master/Countries?token=3D5pJlUp2IZHvQHFQDLocV8srhAKOw03JHg0ufY73W8GMwJl9fSZF65KTmZwbfku";
            var client = new HttpClient();
            var result = client.GetAsync(url).Result;

            if (result.IsSuccessStatusCode)
            {
                var values = result.Content.ReadAsStringAsync().Result;
                return View(values);
            }

            return View();
        }

        public ActionResult TestAddOrganization()
        {
            var organization = new TblOrganizationProfiles
            {
                Createddate = DateTime.Now,
                IsActive = true,
                Updateddate = null,
                IsRegistered = null,
                OrganizatioName = "MagdyCo",
                OrganizationNickName = "Magdy",
                OrganizationTypeId = 1,
                RegisterationNumber = "123456",
            };

            var volunteer = new TblVolunteerProfiles
            {
                AboutmeText = "this is me",
                Skills = "heelo",
                Createddate = DateTime.Now,
                IsActive = false,
                DaysOfWeek = "sat",
                Categories = "hi",
                Updateddate = null,
                ProfileVisibility = "visible",
                DesiredWorkArea = "null",
                TimeAvailability = "all day",
                LookingForText = "lookingfor",
                Diploma = "diploma",
                ProfileImage =ImageToArray(Bitmap.FromFile(@"D:\1982 Magdy Gameel.jpg"),ImageFormat.Jpeg)
            };

            // var url = "http://localhost:4874/api/values/GetValues?token=" + UrlEncode(Session["token"].ToString());
            var url = "http://localhost:4874/api/register/user?token=3D5pJlUp2IZHvQHFQDLocV8srhAKOw03JHg0ufY73W8GMwJl9fSZF65KTmZwbfku";
            var client = new HttpClient();
            var user = new TblUsers
            {
                City = "tanta",
                Createddate = DateTime.Now,
                Country = 10,
                Email = "magdy.bedeer@gmail.com",
                FirstName = "magdy",
                LastName = "gameel",
                IsActive = true,
                IsEmailSubsription = true,
                Password = "password",
                Updateddate = null,
                UserName = "magdyBedeer",
                OrganizationProfiles = new Collection<TblOrganizationProfiles>(new List<TblOrganizationProfiles>() { organization }),
                VolunteerProfile = volunteer
            };

            var result = client.PostAsJsonAsync(url, user).Result;

            if (result.IsSuccessStatusCode)
            {
                string message = result.Content.ReadAsStringAsync().Result;
            }

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public static string UrlEncode(string value)
        {
            var result = new System.Text.StringBuilder();
            foreach (char symbol in value)
            {
                if (unreservedChars.IndexOf(symbol) != -1)
                    result.Append(symbol);
                else
                    result.Append('%' + String.Format("{0:X2}", (int)symbol));
            }
            return result.ToString();
        }
        public string ImageToBase64(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Convert Image to byte[]
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();

                // Convert byte[] to Base64 String
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }

        public byte[] ImageToArray(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using (var ms = new MemoryStream())
            {
                // Convert Image to byte[]
                image.Save(ms, format);
                return ms.ToArray();
            }
        }
        

        private const string unreservedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-_.~";
    }

    public class Consumer
    {
        public string ConsumerKey { get; set; }
        public string ConsumerSecret { get; set; }
    }
    public class TblUsers
    {
        public virtual int Id { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Email { get; set; }
        public virtual string UserName { get; set; }
        public virtual string Password { get; set; }
        public virtual string City { get; set; }
        public virtual int Country { get; set; }
        public virtual bool? IsEmailSubsription { get; set; }
        public virtual DateTime Createddate { get; set; }
        public virtual DateTime? Updateddate { get; set; }
        public virtual bool IsActive { get; set; }
        public virtual TblVolunteerProfiles VolunteerProfile { get; set; }
        public virtual ICollection<TblOrganizationProfiles> OrganizationProfiles { get; set; }
    }

    public class TblOrganizationProfiles
    {
        public int Id { get; set; }
        public TblUsers User { get; set; }
        public int UserId { get; set; }
        public string OrganizatioName { get; set; }
        public string OrganizationNickName { get; set; }
        public bool? IsRegistered { get; set; }
        public string RegisterationNumber { get; set; }
        public int OrganizationTypeId { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? Createddate { get; set; }
        public DateTime? Updateddate { get; set; }
    }

    public class TblVolunteerProfiles
    {
        public virtual int Id { get; set; }
        public virtual TblUsers User { get; set; }
        public virtual int UserId { get; set; }
        public virtual byte[] ProfileImage { get; set; }
        public virtual string AboutmeText { get; set; }
        public virtual string LookingForText { get; set; }
        public virtual string Categories { get; set; }
        public virtual string DesiredWorkArea { get; set; }
        public virtual string Skills { get; set; }
        public virtual string Diploma { get; set; }
        public virtual string TimeAvailability { get; set; }
        public virtual string DaysOfWeek { get; set; }
        public virtual string ProfileVisibility { get; set; }
        public virtual DateTime? Createddate { get; set; }
        public virtual DateTime? Updateddate { get; set; }
        public virtual bool? IsActive { get; set; }
    }
}
