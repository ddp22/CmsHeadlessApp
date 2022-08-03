using CmsHeadlessApp.SupportedClass;
using CmsHeadlessApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsHeadlessApp.View
{
    public class ContentListViewModel : BaseViewModel
    {
        #region Properites
        /*public object mediaWithPath { get; set; }
        public string emailUser { get; set; }*/
        //public List<Attribute> attributes { get; set; }
        //public List<Tag> tag { get; set; }
        //public List<Category> category { get; set; }
        /*public List<string> location { get; set; }
        public int contentId { get; set; }*/
        public ObservableCollection<ContentList> ContentList { get; set; } = new ObservableCollection<ContentList>();
        private string _title;

        public string Title
        {
            get=> _title;
            set=>SetProperty(ref _title, value);
        }
        /*public object media { get; set; }
        public object description { get; set; }
        public DateTime insertionDate { get; set; }
        public string text { get; set; }
        public string userId { get; set; }
        public DateTime? lastEdit { get; set; }
        public object pubblicationDate { get; set; }*/
        //public object contentAttributes { get; set; }
        //public object contentCategory { get; set; }
        //public object contentTag { get; set; }
        //public object user { get; set; }
        //public object contentLocation { get; set; }
        #endregion

        public ContentListViewModel(List<ContentList> contents)
        {
            AddContentList(contents);
        }

        public ContentListViewModel(ContentList contents)
        {
            List<ContentList> temp = new List<ContentList>();
            temp.Add(contents);
            AddContentList(temp);
        }

        private void AddContentList(List<ContentList> contents)
        {
            ContentList.Clear();
            if (contents != null)
            {
                foreach (ContentList content in contents)
                {
                    ContentList.Add(content);
                }
            }
            
        }
    }
}
