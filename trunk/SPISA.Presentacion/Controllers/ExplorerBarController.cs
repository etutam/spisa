using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.IO; 

using Infragistics.Win.UltraWinExplorerBar;
using System.Xml;
using System.Drawing;

namespace SPISA.Presentacion
{
    public class ExplorerBarController
    {
        public static UltraExplorerBar e = null; 

        private ExplorerBarController()
        {

        }

        public static void FillExplorerBar(IList<string> groups, UltraExplorerBar dst)
        {

            if (e == null) e = new UltraExplorerBar(); 
            e = dst;
            e.Groups.Clear();

            Assembly asm = Assembly.GetExecutingAssembly();
            string ResourceName = "SPISA.Presentacion.ExplorerBarGroups.xml";
            Stream stream = asm.GetManifestResourceStream(ResourceName);
            XmlTextReader src = new XmlTextReader(stream);

            bool addItems = false;
            while (src.Read())
            {
                switch (src.NodeType)
                {
                    case XmlNodeType.Element:
                        if (src.Name!="ExplorerBar" && src.Name!="item")
                        {
                            addItems = false; 
                            foreach(string str in groups)
                                if (str == src.GetAttribute("tag").ToString())
                                {
                                    UltraExplorerBarGroup g =  e.Groups.Add(src.GetAttribute("tag").ToString(), src.GetAttribute("name").ToString());

                                    addItems = true; 
                                }
                        }
                        if (src.Name != "ExplorerBar" && src.Name == "item" && addItems == true)
                        {
                            UltraExplorerBarItem i = e.Groups[e.Groups.Count - 1].Items.Add(src.GetAttribute("tag"));
                            i.Settings.AppearancesLarge.Appearance.Image = (src.GetAttribute("icon") != null ? Image.FromFile("Icons/" + src.GetAttribute("icon").ToString()) : null);

                            i.Text = src.ReadElementContentAsString();
                        }
                        
                        break;
                }
            }
        }
    }
}
