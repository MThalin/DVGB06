
using System;
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

        public void ReadXML()
        {
            XmlDocument myDoc = new XmlDocument();
            XmlNode myNode = null;

            try
            {
                myDoc.Load(myFile);
                myNode = myDoc.SelectSingleNode("cookie");

                string gmailuser = myNode.SelectSingleNode("gmailuser").InnerText.Trim();
                string gmailpass = myNode.SelectSingleNode("gmailpass").InnerText.Trim();
                string weathercity = myNode.SelectSingleNode("weathercity").InnerText.Trim();
                string marketstock = myNode.SelectSingleNode("marketstock").InnerText.Trim();

                co.FileReAction(gmailuser, gmailpass, weathercity, marketstock);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void EditXML(string element, string content)
        {
            XmlDocument myDoc = new XmlDocument();
            XmlNode myNode = null;

            try
            {
                myDoc.Load(myFile);
                myNode = myDoc.SelectSingleNode("cookie");

                myNode.SelectSingleNode(element).InnerText = content.Trim();   
                myDoc.Save(myFile);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
