using System.Xml.Linq;

namespace AVV_Label_Extractor.Models
{
    public class TreeItemData
    {
        public string Title { get; set; }

        public string Icon { get; set; }

        public XDocument FileContent { get; set; }

        public bool IsExpanded { get; set; }

        public HashSet<TreeItemData> TreeItems { get; set; }

        public TreeItemData(string title, string icon, XDocument? filecontent = null)
        {
            Title = title;
            Icon = icon;
            FileContent = filecontent;
        }
    }
}
