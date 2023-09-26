namespace MauiApp1;

public partial class Page2 : ContentPage
{
	public Page2(string text)
	{
		InitializeComponent();
		UserName.Text = text;
	}

	private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
	{
        Navigation.PopModalAsync();
    }	
}