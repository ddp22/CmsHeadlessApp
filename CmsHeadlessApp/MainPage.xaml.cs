//using static Android.Provider.DocumentsContract;

using CmsHeadlessApp.SupportedClass;
using CmsHeadlessApp.View;
using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing.Net.Maui;

//using static Android.Gms.Common.Apis.Api;

namespace CmsHeadlessApp;
public partial class MainPage : ContentPage
{
    
    public List<ContentList> contentList;
    public static HttpClient client = new HttpClient();
    private string token;
    //int count = 0;

    //static HttpClient client = new HttpClient();

    public MainPage()
	{
        
        InitializeComponent();
        
        contentList=new List<ContentList>();

        this.GetContentList();
    }

    //private async void SetLocation()
    //{
    //    var temp = await Geolocation.GetLocationAsync();
    //    this.latitude = temp.Latitude;
    //    this.longitude = temp.Longitude;
    //    return;
    //}

    private async Task GetContentList()
    {
        token = await SecureStorage.Default.GetAsync("JwtToken");
        string path = "https://192.168.10.72:8094/Content/GetContent?latitude=" + LoginPage.latitude.ToString().Replace(",", ".") + "&longitude=" + LoginPage.longitude.ToString().Replace(",", ".")+"&token="+token+"&mail="+LoginPage.mail;
        HttpResponseMessage response = await client.GetAsync(path);
        if (response.IsSuccessStatusCode)
        {
            contentList = await response.Content.ReadFromJsonAsync<List<ContentList>>();
            if (contentList == null)
            {

                return;
            }
            this.BindingContext = new ContentListViewModel(contentList);
        }
        else
        {
            return;
        }
    }

    private async void OnLogoutClicked(object sender, EventArgs e)
    {
        LoginPage.latitude = 0;
        LoginPage.longitude = 0;
        LoginPage.mail = null;
        SecureStorage.Default.Remove("JwtToken");
        await Navigation.PushModalAsync(new LoginPage());
    }

    private async void OnQRScannerClicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new QRScanner());
    }

    //public async void GoToDetails()
    //{
    //    await Navigation.PushModalAsync(new ContentDetails());
    //}

    //private void OnCounterClicked(object sender, EventArgs e)
    //{
    //    count++;

    //    if (count == 1)
    //        CounterBtn.Text = $"Clicked {count} time";
    //    else
    //        CounterBtn.Text = $"Clicked {count} times";

    //    SemanticScreenReader.Announce(CounterBtn.Text);
    //}
}

