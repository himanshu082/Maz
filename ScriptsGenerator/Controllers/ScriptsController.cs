using ScriptsGenerator.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using System.Xml;

namespace ScriptsGenerator.Controllers
{
    public class ScriptsController : Controller
    {
        // GET: Script/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Script/Create
        [HttpPost]
        public string Create(GenerateScriptModel generateScriptModel)
        {
            string msg = string.Empty;
            try
            {
                string path = Server.MapPath("~");
                generateScriptModel.MarketingListId = " ";
                generateScriptModel.MarketingListName = " ";
                string lang = generateScriptModel.SelectedLanguages;
                string[] lanuages = lang.Split('/');
                string[] countries = { "US", "MX", "CA", "JP", "HK", "AU", "KR" };

                if (!System.IO.File.Exists(path + @"\Nerium_CapturePages_XML_Script"))
                {
                    System.IO.Directory.CreateDirectory(path + @"\Nerium_CapturePages_XML_Script");
                }

                if (System.IO.File.Exists(path + @"\Nerium_CapturePages_XML_Script\test.xml"))
                {
                    System.IO.File.Delete(path + @"\Nerium_CapturePages_XML_Script\test.xml");
                }

                using (XmlTextWriter xmlWriter = new XmlTextWriter(path + @"\Nerium_CapturePages_XML_Script\test.xml", System.Text.Encoding.UTF8))
                {
                    xmlWriter.WriteStartDocument(true);
                    xmlWriter.Formatting = Formatting.Indented;
                    xmlWriter.Indentation = 2;
                    xmlWriter.WriteStartElement("Script");
                    for (int i = 0; i <= lanuages.Length - 1; i++)
                    {
                        for (int j = 0; j <= countries.Length - 1; j++)
                        {
                            createNode(countries[j] + "-" + lanuages[i], generateScriptModel.PageName, generateScriptModel.TagName, generateScriptModel.MarketingListName, generateScriptModel.MarketingListId, generateScriptModel.CreatedBy, xmlWriter);
                        }
                    }

                    /* Uncomment this part of code when a new country needs to added for an existing capture page */
                    //List<CountryLanguagesDto> countryLangaugesList = GetCountryWithLanguages();
                    //foreach (var siteLang in countryLangaugesList.Where(x => x.Country != generateScriptModel.SiteCountry))
                    //{
                    //    if (siteLang.Country != generateScriptModel.SiteCountry)
                    //    {
                    //        if (siteLang.Languages.Count > 1)
                    //        {
                    //            createNode(generateScriptModel.SiteCountry + "-" + siteLang.Languages[0], generateScriptModel.PageName, generateScriptModel.TagName, generateScriptModel.MarketingListName, generateScriptModel.MarketingListId, generateScriptModel.CreatedBy, xmlWriter);
                    //            createNode(generateScriptModel.SiteCountry + "-" + siteLang.Languages[1], generateScriptModel.PageName, generateScriptModel.TagName, generateScriptModel.MarketingListName, generateScriptModel.MarketingListId, generateScriptModel.CreatedBy, xmlWriter);
                    //        }
                    //        else
                    //            createNode(generateScriptModel.SiteCountry + "-" + siteLang.Languages[0], generateScriptModel.PageName, generateScriptModel.TagName, generateScriptModel.MarketingListName, generateScriptModel.MarketingListId, generateScriptModel.CreatedBy, xmlWriter);
                    //    }

                    //}

                    xmlWriter.WriteEndElement();
                    xmlWriter.WriteEndDocument();
                    xmlWriter.Close();
                }
                ReturnObject ro = new ReturnObject();
                ro.message = "XML Generated";
                var jsonSerialiser = new JavaScriptSerializer();
                var json = jsonSerialiser.Serialize(ro);
                return json;
            }
            catch (Exception ex)
            {
                ReturnObject ro = new ReturnObject();
                ro.message = ex.Message;
                var jsonSerialiser = new JavaScriptSerializer();
                var json = jsonSerialiser.Serialize(ro);
                return json;
            }
        }

        private void createNode(string key, string pName, string tName, string mListName, string mListId, string createdBy, XmlTextWriter writer)
        {
            writer.WriteStartElement("Row");
            writer.WriteStartElement("Key");
            writer.WriteString(key);
            writer.WriteEndElement();
            writer.WriteStartElement("CapturePageName");
            writer.WriteString(pName);
            writer.WriteEndElement();
            writer.WriteStartElement("TagName");
            writer.WriteString(tName);
            writer.WriteEndElement();
            writer.WriteStartElement("MarketingListName");
            writer.WriteString(mListName);
            writer.WriteEndElement();
            writer.WriteStartElement("MarketingListId");
            writer.WriteString(mListId);
            writer.WriteEndElement();
            writer.WriteStartElement("CreatedBy");
            writer.WriteString(createdBy);
            writer.WriteEndElement();
            writer.WriteEndElement();
        }

        public List<CountryLanguagesDto> GetCountryWithLanguages()
        {
            List<CountryLanguagesDto> countryLanguagesList = new List<CountryLanguagesDto>();
            countryLanguagesList.Add(new CountryLanguagesDto { Country = "US", Languages = new List<string>() { "EN-US", "ES-US" } });
            countryLanguagesList.Add(new CountryLanguagesDto { Country = "MX", Languages = new List<string>() { "EN-MX", "ES-MX" } });
            countryLanguagesList.Add(new CountryLanguagesDto { Country = "CA", Languages = new List<string>() { "EN-CA", "FR-CA" } });
            countryLanguagesList.Add(new CountryLanguagesDto { Country = "JP", Languages = new List<string>() { "EN-JP", "JA-JP" } });
            countryLanguagesList.Add(new CountryLanguagesDto { Country = "HK", Languages = new List<string>() { "EN-HK", "ZH-HK" } });
            countryLanguagesList.Add(new CountryLanguagesDto { Country = "AU", Languages = new List<string>() { "EN-AU" } });
            countryLanguagesList.Add(new CountryLanguagesDto { Country = "KR", Languages = new List<string>() { "KO-KR" } });

            return countryLanguagesList;
        }

        public string GetLanguagesByCountry(string country)
        {
            string languages = "";
            string value1 = String.Empty;
            if (value1 == null)
            {
                languages = "not found";
                return languages;
            }
            else
            {
                if (country != null)
                {
                    List<CountryLanguagesDto> countryLangaugesList = GetCountryWithLanguages();
                    CountryLanguagesDto countryLanguagesDto = countryLangaugesList.Where(x => x.Country == country).FirstOrDefault();
                    if (countryLanguagesDto.Languages.Count > 1)
                        languages = countryLanguagesDto.Languages[0].ToString() + "/" + countryLanguagesDto.Languages[1].ToString();
                    else
                        languages = countryLanguagesDto.Languages[0].ToString();
                    var jsonSerialiser = new JavaScriptSerializer();
                    var json = jsonSerialiser.Serialize(languages);
                    return json;
                }
                else
                {
                    ReturnObject ro = new ReturnObject();
                    ro.message = "Please Select a Site Country";
                    var jsonSerialiser = new JavaScriptSerializer();
                    var json = jsonSerialiser.Serialize(ro);
                    return json;
                }
            }
        }
        public class ReturnObject
        {
            public string message { get; set; }
        }
        public string ReadXMLScript()
        {
            Logic _logic = new Logic();
            try
            {
                ReturnObject ro = new ReturnObject();
                string key = "", cPageName = "", tName = "", mListName = "", mListId = "", createdBy = "";
                StringBuilder builder = new StringBuilder();
                string path = Server.MapPath("~");
                XmlDocument xml = new XmlDocument();
                xml.Load(path + @"\Nerium_CapturePages_XML_Script\test.xml");
                XmlNodeList node = xml.DocumentElement.SelectNodes("/Script/Row");

                if (System.IO.File.Exists(path + @"\Nerium_CapturePages_XML_Script\script.sql"))
                {
                    System.IO.File.Delete(path + @"\Nerium_CapturePages_XML_Script\script.sql");
                }

                using (StreamWriter writetext = new StreamWriter(path + @"\Nerium_CapturePages_XML_Script\script.sql"))
                {
                    builder.Append(" BEGIN TRY\n ");
                    foreach (XmlNode xmlNode in node)
                    {

                        key = xmlNode.SelectSingleNode("Key").InnerText;
                        cPageName = xmlNode.SelectSingleNode("CapturePageName").InnerText;
                        tName = xmlNode.SelectSingleNode("TagName").InnerText;
                        mListName = xmlNode.SelectSingleNode("MarketingListName").InnerText;
                        //mListId = _logic.GetMarketingListId(mListName, 10098);
                        mListId = xmlNode.SelectSingleNode("MarketingListId").InnerText;
                        createdBy = xmlNode.SelectSingleNode("CreatedBy").InnerText;
                        builder.Append(" \tIF  NOT EXISTS (SELECT 1 FROM [NeriumUP].[CapturePageTagInfo] WHERE [Key] = '" + key + "'\n ");
                        builder.Append(" \t\t\tand [CapturePageName] = '" + cPageName + "')\n ");
                        builder.Append(" \t\tBEGIN\n\n ");
                        builder.Append(" \t\t\t\tInsert into [NeriumUP].[CapturePageTagInfo]\n"
                                        + "\t\t\t\t([Key],\n\t\t\t\t[CapturePageName],\n\t\t\t\t[TagName],\n\t\t\t\t[TagId],\n "
                                    + "\t\t\t\t[MarketingListName],\n\t\t\t\t[MarketingListId],\n\t\t\t\t[ModifiedBy],\n\t\t\t\t[ModifiedDate],\n\t\t\t\t[CreatedBy],\n\t\t\t\t[CreatedDate])\n ");
                        builder.Append("\t\t\t\tvalues\n\t\t\t\t('" + key + "',\n\t\t\t\t'" + cPageName + "',\n\t\t\t\t'" + tName + "',\n\t\t\t\t'',\n\t\t\t\tN'" + mListName + "',\n\t\t\t\t"
                                        + "'" + mListId + "',\n\t\t\t\t null,\n\t\t\t\t null,\n\t\t\t\t '" + createdBy + "',\n\t\t\t\t getdate())\n");
                        builder.Append(" \t\t\t\tPRINT 'CapturePageTagInfo with key ''" + key + "'' and capture ''" + tName + "'' is inserted successfully...'; \n");
                        builder.Append(" \t\tEND\n \t\tELSE\n \t\tPRINT 'CapturePageTagInfo with key ''" + key + "'' "
                                        + " and capture ''" + tName + "'' is already exists!!' ");
                        builder.Append("\n\n");

                    }
                    builder.Append("END TRY\n BEGIN CATCH\n \tPRINT 'In CATCH Block'\n \tSELECT ERROR_MESSAGE() AS ErrorMessage;\n END CATCH;");
                    writetext.WriteLine(builder);
                }
                ro.message = "Script Generated";
                var jsonSerialiser = new JavaScriptSerializer();
                var json = jsonSerialiser.Serialize(ro);
                return json;
            }
            catch (Exception e)
            {
                ReturnObject ro = new ReturnObject();
                ro.message = e.Message;
                var jsonSerialiser = new JavaScriptSerializer();
                var json = jsonSerialiser.Serialize(ro);
                return json;
            }
        }
    }
}