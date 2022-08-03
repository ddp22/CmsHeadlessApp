//using static Android.Provider.DocumentsContract;

using CmsHeadlessApp.SupportedClass;
using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;

namespace CmsHeadlessApp;

public partial class LoginPage : ContentPage
{
    //int count = 0;
    public static double latitude;
    public static double longitude;
    static HttpClient client = new HttpClient();
    public static string mail;

    public LoginPage()
	{
		InitializeComponent();
    }

    private async void OnLoginClicked(object sender, EventArgs e)
	{
        var temp = await Geolocation.GetLocationAsync();
        latitude = temp.Latitude;
        longitude = temp.Longitude;
        ErrorMessage.IsVisible = false;
        CorrectEmailPassword.IsVisible = false;
        if (email.Text == null || email.Text == "")
		{
			MissingEmail.IsVisible = true;
            MissingPassword.IsVisible = false;
            return;
        }
		else
		{
			MissingEmail.IsVisible = false;
		}

        if (password.Text == null || password.Text == "")
        {
            MissingPassword.IsVisible = true;

            return;
        }
		else
		{
            MissingPassword.IsVisible = false;
        }

		Root statusLogin = null;
        Uri u = new Uri("https://localhost:7274/User/LoginUser?mail=" + email.Text + "&password=" + password.Text);
        
		
        HttpResponseMessage response =await client.PostAsync(u, null);
        if (response.IsSuccessStatusCode)
        {
            statusLogin = await response.Content.ReadFromJsonAsync<Root>();
            if (statusLogin == null)
            {
                ErrorMessage.Text = "Generic Error";
                ErrorMessage.IsVisible = true;
                return;
            }
            if (statusLogin.user != null)
            {
                await SecureStorage.Default.SetAsync("JwtToken", statusLogin.token);
                mail = statusLogin.user.email;
            }
        }
		else
		{
            
			return;
		}

		if(statusLogin.result)
		{
            ErrorMessage.IsVisible= false;
			CorrectEmailPassword.IsVisible = true;
            await Navigation.PushModalAsync(new MainPage());
        }
		else
		{
            ErrorMessage.Text=statusLogin.details;
            ErrorMessage.IsVisible = true;
            CorrectEmailPassword.IsVisible = false;
        }


        
        return;
    }

    /*private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}*/
}

