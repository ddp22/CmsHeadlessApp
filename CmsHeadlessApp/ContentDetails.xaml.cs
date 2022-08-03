using CmsHeadlessApp.SupportedClass;
using CmsHeadlessApp.View;

namespace CmsHeadlessApp;

public partial class ContentDetails : ContentPage
{
	public ContentDetails(ContentList contentList)
	{
		InitializeComponent();
        if(contentList != null)
        {
            if(contentList.MediaWithPath != null)
            {
                contentList.Media = contentList.MediaWithPath.ToString();
                MediaLabel.Source = contentList.MediaWithPath.ToString();
            }
            else
            {
                MediaLabel.IsVisible = false;
                MediaText.IsVisible = false;
            }
            TitleLabel.Text = contentList.Title;
            if (contentList.Description!=null)
            {
                DescriptionLabel.Text = contentList.Description.ToString();
            }
            else
            {
                DescriptionLabel.IsVisible = false;
                DescriptionText.IsVisible = false;
            }
            TextLabel.Text= contentList.Title;
            InsertionDateLabel.Text = contentList.InsertionDate.ToString();
            if (contentList.PubblicationDate != null)
            {
                PubblicationDateLabel.Text = contentList.PubblicationDate.ToString();
            }
            else
            {
                PubblicationDateLabel.IsVisible = false;
                PubblicationDateText.IsVisible = false;
            }
            if (contentList.LastEdit != null)
            {
                LastEditLabel.Text = contentList.LastEdit.ToString();
            }
            else
            {
                LastEditLabel.IsVisible = false;
                LastEditText.IsVisible = false;
            }
            //LastEditLabel.Text = contentList.LastEdit!=null? contentList.LastEdit.ToString() : null;
            //PubblicationDateLabel.Text = contentList.PubblicationDate != null ? contentList.PubblicationDate.ToString() : null;
            EmailLabel.Text = contentList.EmailUser;
        }
        
        /*if (contentList != null)
		{
            this.BindingContext = new ContentListViewModel(contentList);
        }*/

        

    }

    private async void OnReturnClicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new MainPage());
    }
}