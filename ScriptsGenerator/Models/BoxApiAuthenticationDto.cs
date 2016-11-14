using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScriptsGenerator.Models
{
    public class BoxApiAuthenticationDto
    {
        public string access_token { get; set; }
        public string token_type { get; set; }
        public string expires_in { get; set; }
        public string CustomerID { get; set; }
        public string Country { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Language { get; set; }
        public string CurrentRank { get; set; }
        public string NextRank { get; set; }
        public string CurrentRankID { get; set; }
        public string NextRankID { get; set; }
        public string BannerImageURL { get; set; }
        public string BannerLinkURL { get; set; }
    }
}