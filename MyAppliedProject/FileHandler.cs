
using System;
using System.IO;
using System.Text;
using System.Xml;

namespace MyAppliedProject
{
    class FileHandler
    {
        Controller co;
        string myFile;

        public FileHandler(Controller coIn)
        {
            co = coIn;
            myFile = "ChocolateChipCookie.xml";

            ReadXML();
        }

        public void CreateXML()
        {
            try
            {
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Indent = true;
                settings.Encoding = Encoding.UTF8;
                XmlWriter writer = XmlWriter.Create("ChocolateChipCookie.xml", settings);

                writer.WriteStartDocument();
                writer.WriteStartElement("cookies");

                writer.WriteElementString("rgb", "128,255,255");
                writer.WriteElementString("height", "400");
                writer.WriteElementString("width", "400");
                writer.WriteElementString("passcheck", "True");
                writer.WriteElementString("chosenmail", "gmail");
                writer.WriteElementString("gmailuser", "");
                writer.WriteElementString("gmailpass", "");
                writer.WriteElementString("outlookuser", "");
                writer.WriteElementString("outlookpass", "");
                writer.WriteElementString("weathercheck", "True");
                writer.WriteElementString("weathercity", "");
                writer.WriteElementString("marketcheck", "True");
                writer.WriteElementString("marketstock", "");
                writer.WriteElementString("performancecheck", "False");

                writer.WriteEndElement();
                writer.Close();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void ReadXML()
        {
            XmlDocument myDoc = new XmlDocument();
            XmlNode myNode = null;

            try
            {
                if (!File.Exists(myFile))
                {
                    CreateXML();
                }
                myDoc.Load(myFile);
                myNode = myDoc.SelectSingleNode("cookies");

                string rgb = myNode.SelectSingleNode("rgb").InnerText.Trim();
                string height = myNode.SelectSingleNode("height").InnerText.Trim();
                string width = myNode.SelectSingleNode("width").InnerText.Trim();
                string passcheck = myNode.SelectSingleNode("passcheck").InnerText.Trim();
                string chosenmail = myNode.SelectSingleNode("chosenmail").InnerText.Trim();
                string gmailuser = myNode.SelectSingleNode("gmailuser").InnerText.Trim();
                string gmailpass = myNode.SelectSingleNode("gmailpass").InnerText.Trim();
                string outlookuser = myNode.SelectSingleNode("outlookuser").InnerText.Trim();
                string outlookpass = myNode.SelectSingleNode("outlookpass").InnerText.Trim();
                string weathercheck = myNode.SelectSingleNode("weathercheck").InnerText.Trim();
                string weathercity = myNode.SelectSingleNode("weathercity").InnerText.Trim();
                string marketcheck = myNode.SelectSingleNode("marketcheck").InnerText.Trim();
                string marketstock = myNode.SelectSingleNode("marketstock").InnerText.Trim();
                string performancecheck = myNode.SelectSingleNode("performancecheck").InnerText.Trim();

                co.FileReAction(rgb, height, width, passcheck, chosenmail, gmailuser, gmailpass, outlookuser, outlookpass, weathercheck, weathercity, marketcheck, marketstock, performancecheck);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void EditXML(string element, string content)
        {
            try
            {
                if (element == "reset")
                {
                    CreateXML();
                    co.FileReAction("128,255,255", "400", "400", "True", "gmail", "", "", "", "", "True", "", "True", "", "False");
                }

                else 
                {
                    XmlDocument myDoc = new XmlDocument();
                    XmlNode myNode = null;
                    myDoc.Load(myFile);
                    myNode = myDoc.SelectSingleNode("cookies");
                    myNode.SelectSingleNode(element).InnerText = content.Trim();
                    myDoc.Save(myFile);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
