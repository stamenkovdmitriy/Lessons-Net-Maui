using System.Diagnostics;

namespace Lessons_Net_Maui;

public partial class FirstPage : ContentPage
{
	public FirstPage()
	{
		InitializeComponent();
	}
    private void Button_Clicked(object sender, EventArgs e)
    {
        Debug.WriteLine("Clicked !");
    }

    int count = 0;
    private void Button_Clicked_1(object sender, EventArgs e)
    {
        count++;
        currentLabel.Text = $"current count: {count}";
    }
}