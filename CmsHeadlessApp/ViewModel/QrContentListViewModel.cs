using CmsHeadlessApp.SupportedClass;
using CmsHeadlessApp.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsHeadlessApp.ViewModel
{
    internal class QrContentListViewModel : BaseViewModel
    {
        #region Properites
        /*public object mediaWithPath { get; set; }
        public string emailUser { get; set; }*/
        //public List<Attribute> attributes { get; set; }
        //public List<Tag> tag { get; set; }
        //public List<Category> category { get; set; }
        /*public List<string> location { get; set; }
        public int contentId { get; set; }*/
        public ObservableCollection<QrRoot> ContentList { get; set; } = new ObservableCollection<QrRoot>();
        private string _title;

        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
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

        public QrContentListViewModel(QrRoot root)
        {
            AddContentList(root);
        }

        //public QrContentListViewModel(QrRoot root)
        //{
        //    List<ContentParent> parent = new List<ContentParent>();
        //    List<ContentChild> child = new List<ContentChild>();
        //    parent.Add(contentsParent);
        //    child.Add(contentsChild);
        //    AddContentList(child, parent);
        //}

        private void AddContentList(QrRoot root)
        {
            ContentList.Clear();

            if (root != null)
            {
                ContentList.Add(root);
            }

        }
    }
}
