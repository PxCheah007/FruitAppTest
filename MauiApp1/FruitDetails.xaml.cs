namespace MauiApp1;

public partial class FruitDetails : ContentPage
{

    public FruitDetails(string fruitName, string fruitImage, string fruitDescription)
	{
        InitializeComponent();
        showName.Text = fruitName;
        showImage.Source = fruitImage;
        showDescription.Text = fruitDescription;
	}
}