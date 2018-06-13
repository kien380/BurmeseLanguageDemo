using Xamarin.Forms;

namespace BurmeseLanguageDemo
{
	public partial class MainPage : TabbedPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void TextChanged(object sender, TextChangedEventArgs e)
        {
            LabelUnicode.Text = LabelZawgyi.Text = e.NewTextValue;
        }

        private void TextChanged2(object sender, TextChangedEventArgs e)
        {
            LabelDisplay.Text = LabelDisplayBold.Text = LabelDisplayItalic.Text = e.NewTextValue;
        }

	    private void Switch_OnToggled(object sender, ToggledEventArgs e)
	    {
	        if (Toggle.IsToggled)
	        {
                LabelDisplay.FontFamily = Device.RuntimePlatform == Device.Android ? "ZawgyiOne.ttf#Zawgyi-One" : "Zawgyi-One";
                LabelDisplayBold.FontFamily = Device.RuntimePlatform == Device.Android ? "ZawgyiOne.ttf#Zawgyi-One" : "Zawgyi-One";
                LabelDisplay.FontFamily = Device.RuntimePlatform == Device.Android ? "ZawgyiOne.ttf#Zawgyi-One" : "Zawgyi-One";
            }
	        else
	        {
	            LabelDisplay.FontFamily = "";
	            LabelDisplayBold.FontFamily = "";
	            LabelDisplayItalic.FontFamily = "";
            }
	    }
	}
}
