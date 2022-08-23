using QRCodeDecoderLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AForge.Video;
using AForge.Video.DirectShow;

namespace CmsHeadlessApp.SupportedClass
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class ContentChild
    {
        public int contentId { get; set; }
        public string title { get; set; }
        public string media { get; set; }
        public string description { get; set; }
        public DateTime insertionDate { get; set; }
        public string text { get; set; }
        public string userId { get; set; }
        public DateTime lastEdit { get; set; }
        public object pubblicationDate { get; set; }
        public object contentAttributes { get; set; }
        public object contentCategory { get; set; }
        public object contentTag { get; set; }
        public object user { get; set; }
        public object contentLocation { get; set; }
    }

    public class ContentParent
    {
        public int contentId { get; set; }
        public string title { get; set; }
        public object media { get; set; }
        public object description { get; set; }
        public DateTime insertionDate { get; set; }
        public string text { get; set; }
        public string userId { get; set; }
        public object lastEdit { get; set; }
        public object pubblicationDate { get; set; }
        public object contentAttributes { get; set; }
        public object contentCategory { get; set; }
        public object contentTag { get; set; }
        public object user { get; set; }
        public object contentLocation { get; set; }
    }

    public class QrRoot
    {
        public ContentParent contentParent { get; set; }
        public List<ContentChild> contentChild { get; set; }
    }

}
