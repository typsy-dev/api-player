using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using asp_net_core.Models;
using asp_net_core.Services;
using asp_net_core.Utilties;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace asp_net_core.Controllers
{
    public class PlayerController : Controller
    {
        //private const string TYPSY_ACCOUNT_ID = "INSERT TYPSY ACCOUNT ID";
        private const string TYPSY_ACCOUNT_ID = "INSERT THE ACCOUNT ID";
        private const string TYPSY_SOURCE = "INSERT THE SOURCE NAME";
        private const string TYPSY_KEY = "INSERT THE SOURCE NAME";

        public ActionResult Index()
        {
            // Fetch the lesson from the Typsy API
            Lesson lesson = LessonService.Get(100);

            string timestamp = DateTime.UtcNow.ToString("O");
            string encryptedKeyTemplate = $"{TYPSY_KEY}:{timestamp}";
            string encryptedKey = EncryptionHelper.CreateHmacSha256(encryptedKeyTemplate, TYPSY_KEY);

            // INSERT LOGIC TO LOOKUP THE EMAIL ADDRESS OF THE USER ACCESSING THE PAGE
            string email = "bob.smith@yourcompany.com";
            string firstname = "Bob";
            string lastname = "Smith";

            var referrer = $"{this.Request.Scheme}://{this.Request.Host}{this.Request.Path}{this.Request.QueryString}";

            PlayerViewModel viewModel = new PlayerViewModel();

            viewModel.ApiEndpoint = "https://api.typsy.com";
            viewModel.Lesson = lesson;
            viewModel.AccountId = TYPSY_ACCOUNT_ID;
            viewModel.EncryptedKey = encryptedKey;
            viewModel.Source = TYPSY_SOURCE;
            viewModel.Referrer = referrer;
            viewModel.Timestamp = timestamp;
            viewModel.Email = email;
            viewModel.Firstname = firstname;
            viewModel.Lastname = lastname;

            return View(viewModel);
        }
    }
}