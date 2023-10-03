using System.ComponentModel;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        List<Fruit> list = new List<Fruit>() 
        {
            new Fruit() {Name="Apple", Image="apple.png", Description="This is an Apple"},
            new Fruit() {Name="Orange", Image="orange.png", Description="This is an Orange"},
            new Fruit() {Name="Grape", Image="grape.png", Description="This is a Grape"},
            new Fruit() {Name="Banana", Image="banana.png", Description="This is a Banana"},
            new Fruit() {Name="Pear", Image="pear.png", Description="This is a Pear"},
            new Fruit() {Name="Pineapple", Image="pineapple.png", Description="This is a Pineapple"},
            new Fruit() {Name="Strawberry", Image="strawberry.png", Description="This is a Strawberry"},
            new Fruit() {Name="Watermelon", Image="watermelon.png", Description="This is a Watermelon"}
        };

        public MainPage()
        {
            InitializeComponent();
            FruitListView.ItemsSource = list;
        }

        //give a list view item selected event handler code
        private void FruitListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if(e.SelectedItem == null)
                return; 
            var selectedItem = e.SelectedItem as Fruit;
            //DisplayAlert("Selected", selectedItem.Name, "OK");
            //((ListView)sender).SelectedItem = null;
            Navigation.PushAsync(new FruitDetails(selectedItem.Name, selectedItem.Image, selectedItem.Description));
        }

        //private void BtnMoveNext_Clicked(object sender, EventArgs e)
        //{
        //    Navigation.PushAsync(new Page2(entUserName.Text));
        //}
    }
}