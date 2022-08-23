//using Android.Gms.Common.Apis;
using CmsHeadlessApp.SupportedClass;
using CmsHeadlessApp.View;
using CmsHeadlessApp.ViewModel;
using System.Net.Http.Json;

namespace CmsHeadlessApp;

public partial class QRScanner : ContentPage
{
    public QrRoot qrRoot;
    public static HttpClient client = new HttpClient();
    private string token;

    public QRScanner()
	{
		InitializeComponent();
	}
    private void CameraBarcodeReaderView_BarcodesDetected(object sender, ZXing.Net.Maui.BarcodeDetectionEventArgs e)
    {
        Dispatcher.Dispatch(async () =>
        {
            //barcodeResult.Text = $"{e.Results[0].Value}";
            token = await SecureStorage.Default.GetAsync("JwtToken");
            string path = "http://192.168.10.72:8093/QrCode/GetContentByQrCode?label=" + $"{e.Results[0].Value}" + "&mail=" + LoginPage.mail + "&token=" + token;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                qrRoot = await response.Content.ReadFromJsonAsync<QrRoot>();
                if (qrRoot == null)
                {
                    return;
                }
                barcodeResult.BindingContext = new QrContentListViewModel(qrRoot);
            }
            else
            {
                return;
            }
        });
    }
}