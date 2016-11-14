using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScriptsGenerator.Models
{
    public class GenerateScriptModel
    {
        public string TagName { get; set; }
        public string SiteCountry { get; set; }
        public string SelectedLanguages { get; set; }
        public string MarketingListName { get; set; }
        public string MarketingListId { get; set; }
        public string PageName { get; set; }
        public string CreatedBy { get; set; }
        public List<CountryLanguagesDto> CountryLanguagesDtoList { get; set; }
    }
    public class CountryLanguagesDto
    {
        public string Country { get; set; }
        public List<string> Languages { get; set; }

    }
}