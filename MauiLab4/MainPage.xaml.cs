namespace MauiLab4
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BuildProductGroups productGroups = new BuildProductGroups();

            ListView myListView = new ListView();
            myListView.ItemsSource = productGroups.ProductList;
            myListView.IsGroupingEnabled = true;
            myListView.SelectionMode = ListViewSelectionMode.Single;
            myListView.HasUnevenRows = true;

            myListView.GroupHeaderTemplate = new DataTemplate(typeof(GroupHeader));


            //myListView.RowHeight = 80;
            myListView.BackgroundColor = Colors.DarkGoldenrod;
            myListView.SeparatorColor = Colors.LightCoral;
            
            Content = myListView;
            Title = "Product List";

            myListView.ItemTemplate = new DataTemplate(typeof(ListofProductsCell));


            myListView.ItemTapped += async (sender, e) =>
            {
                Product item = (Product)e.Item;
                await DisplayAlert("Item Selected", item.Name.ToString() +
                    " was selected.\nDescription: "+item.Description+"\nPrice: " + item.Price, "Confirm");
                ((ListView)sender).SelectedItem = null;
            };


        }



        class ListofProductsCell : ViewCell
        {
            public ListofProductsCell()
            {
                Label nameLabel = new Label
                {
                    HorizontalOptions = LayoutOptions.Fill,
                    FontSize = 25,
                    FontAttributes = FontAttributes.Bold,
                    TextColor = Colors.White
                };
                nameLabel.SetBinding(Label.TextProperty, "Name");


                Label descriptionLabel = new Label
                {
                    HorizontalOptions = LayoutOptions.Fill,
                    FontSize = 20,
                    TextColor = Colors.AntiqueWhite,
                    LineBreakMode = LineBreakMode.WordWrap
                };
                descriptionLabel.SetBinding(Label.TextProperty, "Description");

                VerticalStackLayout vstack = new VerticalStackLayout
                {
                    Padding = new Thickness(15,10,15,0),
                    Spacing = 10,
                    HorizontalOptions = LayoutOptions.Fill,
                    MinimumHeightRequest = 80,
                    WidthRequest = 400, //Prices are all aligned to the right with this fixed width. However, this is not a proper solution for screens of various sizes, such as mobile phones. 
                    Children =
                    {
                        nameLabel, descriptionLabel
                    }
                };



                Image productImage = new Image
                {
                    HeightRequest = 75,
                    WidthRequest = 75,
                    Aspect = Aspect.AspectFill,
                    HorizontalOptions = LayoutOptions.Start,
                    VerticalOptions = LayoutOptions.Center
                };
                productImage.SetBinding(Image.SourceProperty, "imageSource");


                Label priceLabel = new Label
                {
                    HorizontalOptions = LayoutOptions.End,
                    VerticalOptions = LayoutOptions.Center,
                    FontSize = 15,
                    FontAttributes = FontAttributes.Bold,
                    TextColor = Colors.Green
                };
                priceLabel.SetBinding(Label.TextProperty, "Price");

                HorizontalStackLayout hstack = new HorizontalStackLayout
                {
                    Padding = new Thickness(20, 10, 20, 10),
                    Spacing = 15,
                    HorizontalOptions = LayoutOptions.Fill,
                    //HeightRequest = 40,
                    Children =
                    {
                        productImage, vstack, priceLabel
                    }
                };
                View = hstack;
            }
        }
    }
}
