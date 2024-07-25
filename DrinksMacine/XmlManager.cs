using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DrinksMacine
{
    internal class XmlManager
    {

        private string nameFile = "DarinksMechine.xml";
        //opens or creates a xml file
        public XmlDocument GetXmlDocument()
        {
            XmlDocument xmlDocument = new XmlDocument();
            if (File.Exists(nameFile))
            {
                try
                {
                    xmlDocument.Load(nameFile);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error loading xml file: " + ex.Message);
                }

            }
            else
            {
                XmlNode root = xmlDocument.CreateElement("Drinks");
                xmlDocument.AppendChild(root);
                xmlDocument.Save(nameFile);
            }
            return xmlDocument;

        }

    }
}
