using LogLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WanjuDidSystemManagement
{
    public class XmlRead
    {
        public List<ConstructListControl> XmlReader(string filePath)
        {


            List<ConstructListControl> depList = new List<ConstructListControl>();
            string uri = filePath;
            try
            {
                XmlDocument xml = new XmlDocument();
                xml.Load(uri);
                XmlNodeList xmlList = xml.SelectNodes("root/member");
                foreach (XmlNode xn in xmlList)
                {

                    var user = new ConstructListControl();

                    user.Index = xn["INDEX"].InnerText;
                    user.Dept = xn["DEPT"].InnerText;
                    user.Name = xn["NAME"].InnerText;
                    user.Team = xn["TEAM"].InnerText;
                    user.Work = xn["WORK"].InnerText;
                    user.Tel = xn["TEL"].InnerText;
                    user.Visibility = xn["VISIBILITY"].InnerText;
                    depList.Add(user);
                }
                return depList;
            }
            catch (Exception ex)
            {
                WriteLog.WriteLogger(ex.ToString());
                return depList;
            }
        }

        public string XmlParser(string filePath,int index)
        {
            string retrunTxt = string.Empty;
            string url = filePath;
            int rowIndex = 0;

            try
            {

                XmlDocument xml = new XmlDocument();
                xml.Load(url);
                XmlNodeList xmlList = xml.SelectNodes("root/member");

                foreach (XmlNode xn in xmlList)
                {
                    if (index == rowIndex)
                        retrunTxt = xn["INDEX"].InnerText + "," + xn["DEPT"].InnerText + "," + xn["NAME"].InnerText +
                            "," + xn["TEAM"].InnerText + "," + xn["WORK"].InnerText + "," + xn["TEL"].InnerText + "," + xn["VISIBILITY"].InnerText;

                    rowIndex++;
                }

                return retrunTxt;
            }
            catch(Exception ex)
            {
                WriteLog.WriteLogger(ex.ToString());
                return retrunTxt;
            }
        }

        public void XmlSave(string filePath, int userIndex, string userName, string team, string work, string tel, string visibility)
        {
            try
            {

                int rowIndex = 0;
                XmlDocument xml = new XmlDocument();
                xml.Load(filePath);
                XmlNodeList xmlList = xml.SelectNodes("root/member");

                foreach (XmlNode xn in xmlList)
                {
                    if (userIndex == rowIndex)
                    {
                        xn["NAME"].InnerText = userName;
                        xn["TEAM"].InnerText = team;
                        xn["WORK"].InnerText = work;
                        xn["TEL"].InnerText = tel;
                        xn["VISIBILITY"].InnerText = visibility;

                        xml.Save(filePath);
                        break;
                    }
                    rowIndex++;
                }
            }
            catch(Exception ex) { WriteLog.WriteLogger(ex.ToString()); }
        }

        public string AppSettingXmlParser(string path)
        {
            string ipTxt = string.Empty;
            XmlDocument xml = new XmlDocument();
            xml.Load(path);
            XmlNodeList xmlList = xml.SelectNodes("root");

            foreach (XmlNode xn in xmlList)
            {
                ipTxt = xn["IPAddress"].InnerText;  
            }

            return ipTxt;
        }

        public void AppSettingXmlSave(string ipAddress,string path)
        {
            try
            {

                XmlDocument xml = new XmlDocument();
                xml.Load(path);
                XmlNodeList xmlList = xml.SelectNodes("root");

                foreach (XmlNode xn in xmlList)
                {

                    xn["IPAddress"].InnerText = ipAddress;

                    xml.Save(path);

                }
            }
            catch(Exception ex) { WriteLog.WriteLogger(ex.ToString()); }

        }

        public string PhotoXmlParer(string filePath)
        {
            string returnTxt = string.Empty;
            try
            {
                XmlDocument xml = new XmlDocument();
                xml.Load(filePath);
                XmlNodeList xmlList = xml.SelectNodes("root/content");

                foreach (XmlNode xn in xmlList)
                {
                    returnTxt = xn["TEXT"].InnerText;
                }
                return returnTxt;
            }
            catch(Exception ex) 
            {
                WriteLog.WriteLogger(ex.ToString());
                return returnTxt;
            }
        }

        public void PhotoRemarkXmlAdd(string path,string photoRemrk)
        {
            try
            {

                XmlDocument xml = new XmlDocument();
                xml.AppendChild(xml.CreateXmlDeclaration("1.0", "utf-8", "yes"));
                XmlNode mainNode = xml.CreateElement("root");
                xml.AppendChild(mainNode);
                XmlElement subNode = xml.CreateElement("content");
                mainNode.AppendChild(subNode);
                XmlElement textNode = xml.CreateElement("TEXT");
                textNode.InnerText = photoRemrk;
                subNode.AppendChild(textNode);



                //XmlNode xmlnode = xml.CreateElement("root");
                //XmlNode subXmlnode = xml.CreateElement("content");
                //XmlNode textXmlNode = xml.CreateElement("TEXT");
                //textXmlNode.InnerText = photoRemrk;
                //xml.AppendChild(xmlnode);
                //xml.AppendChild(subXmlnode);
                //xml.AppendChild(textXmlNode);

                //xml.AppendChild(xmlnode);
                //xmlnode.InnerText = photoRemrk;

                //XmlNode textXmlNode = xml.CreateElement("TEXT");
                //xmlnode.AppendChild(subXmlnode);
                //subXmlnode.AppendChild(textXmlNode);

                //textXmlNode.InnerText = photoRemrk;

                xml.Save(path);
            }
            catch(Exception ex) { WriteLog.WriteLogger(ex.ToString()); }
        }
    }

    public class ConstructListControl
    {
        public string Index { get; set; }
        public string Dept { get; set; }
        public string Name { get; set; }
        public string Team { get; set; }
        public string Work { get; set; }
        public string Tel { get; set; }
        public string Visibility { get; set; }
    }
}
