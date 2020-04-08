// Decompiled with JetBrains decompiler
// Type: Записная_книжка.SettingsWorker
// Assembly: Записная книжка, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A0D518A3-D4BA-4371-9C44-D7D6E9D22E50
// Assembly location: D:\Драгоценный исходник записной книжки\Записная книжка.exe

using System.Xml;

namespace Записная_книжка
{
  internal class SettingsWorker
  {
    public void CreateSettings(string Path)
    {
      XmlDocument xmlDocument = new XmlDocument();
      xmlDocument.CreateElement("Table").AppendChild((XmlNode) xmlDocument.CreateTextNode("0"));
      xmlDocument.Save(Path);
    }

    public string GetSetting(string Path, string Setting, string Value)
    {
      XmlDocument xmlDocument = new XmlDocument();
      xmlDocument.Load(Path);
      foreach (XmlNode xmlNode in (XmlNode) xmlDocument.DocumentElement)
      {
        if (xmlNode.Attributes.Count > 0)
        {
          XmlNode namedItem = xmlNode.Attributes.GetNamedItem(Setting);
          if (namedItem != null)
            return namedItem.FirstChild.InnerText;
        }
      }
      return "";
    }

    public void SetSetting(string Path, string Setting, string Value)
    {
      XmlDocument xmlDocument = new XmlDocument();
      xmlDocument.Load(Path);
      foreach (XmlNode xmlNode in (XmlNode) xmlDocument.DocumentElement)
      {
        if (xmlNode.Attributes.Count > 0)
        {
          XmlNode namedItem = xmlNode.Attributes.GetNamedItem(Setting);
          if (namedItem != null)
            namedItem.FirstChild.InnerText = Value;
        }
      }
    }

    public void NewSetting(string Path, string Setting, string Value)
    {
      XmlDocument xmlDocument = new XmlDocument();
      xmlDocument.Load(Path);
      XmlElement documentElement = xmlDocument.DocumentElement;
      xmlDocument.CreateElement(Setting).AppendChild((XmlNode) xmlDocument.CreateTextNode(Value));
    }
  }
}
