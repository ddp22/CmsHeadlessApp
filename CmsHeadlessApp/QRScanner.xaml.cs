namespace CmsHeadlessApp;

public partial class QRScanner : ContentPage
{
	public QRScanner()
	{
		InitializeComponent();
	}
    private void CameraBarcodeReaderView_BarcodesDetected(object sender, ZXing.Net.Maui.BarcodeDetectionEventArgs e)
    {
        Dispatcher.Dispatch(() =>
        {
            barcodeResult.Text = $"{e.Results[0].Value}";
        });
    }
}