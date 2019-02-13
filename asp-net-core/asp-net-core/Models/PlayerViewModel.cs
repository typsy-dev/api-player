using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Typsy.Demo.Player.Models
{
    public class PlayerViewModel
    {
        public Lesson Lesson { get; set; }

        public string EncryptedKey { get; set; }

        public string Timestamp { get; set; }

        public string Source { get; set; }

        public string AccountId { get; set; }

        public string Referrer { get; set; }

        public string ApiEndpoint { get; set; }

        public string Email { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }
    }
}
