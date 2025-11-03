using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace GameFramework
{
    public static class ReadConfigUtility
    {
        public static WorldConfig ReadConfig(string fullFileName)
        {
            WorldConfig config = WorldConfig.Instance;

            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(fullFileName);

            XmlNode? maxXNode = xmlDocument.DocumentElement?.SelectSingleNode("MaxX");
            if (maxXNode != null)
            {
                config.MaxX = Convert.ToInt32(maxXNode.InnerText.Trim());
            }            

            XmlNode? maxYNode = xmlDocument.DocumentElement?.SelectSingleNode("MaxY");
            if (maxYNode != null)
            {
                config.MaxY = Convert.ToInt32(maxYNode.InnerText.Trim());
            }

            XmlNode? difficultyNode = xmlDocument.DocumentElement?.SelectSingleNode("Dificulty");
            if (difficultyNode != null)
            {
                config.Difficulty = (Difficulty)Enum.Parse(typeof(Difficulty), difficultyNode.InnerText.Trim());
            }

            return config;
        }
    }
}
