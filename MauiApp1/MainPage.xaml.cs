using System.ComponentModel;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        List<string> list = new List<string>() 
        { new Fruit() {Name="Apple", Image="apple.png", Description="This is an Apple"},
          new Fruit() {Name="Orange", Image="orange.png", Description="This is an Orange"},
          new Fruit() {Name="Banana", Image="banana.png", Description="This is a Banana"},
          new Fruit() {Name="Mango", Image="mango.png", Description="This is a Mango"},
          new Fruit() {Name="Grapes", Image="grapes.png", Description="This is a Grapes"},
          new Fruit() {Name="Pineapple", Image="pineapple.png", Description="This is a Pineapple"},
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
            DisplayAlert("Selected", selectedItem.Name, "OK");
            ((ListView)sender).SelectedItem = null;
        }

        //private void BtnMoveNext_Clicked(object sender, EventArgs e)
        //{
        //    Navigation.PushAsync(new Page2(entUserName.Text));
        //}
    }
}