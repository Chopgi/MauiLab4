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

            myListView.GroupDisplayBinding = new Binding("GroupName");
            myListView.SetBinding(Label.TextProperty, new Binding("Name", source : productGroups.ProductList));
            myListView.RowHeight = 80;
            myListView.BackgroundColor = Colors.DarkGoldenrod;
            myListView.SeparatorColor = Colors.LightCoral;
            
            Content = myListView;
            Title = "Product List";

            myListView.ItemTemplate = new DataTemplate(typeof(ListofProductsCell));
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
                    //Padding = new Thickness(15,10,15,10),
                    Spacing = 20,
                    WidthRequest = 500,
                    Children =
                    {
                        nameLabel, descriptionLabel
                    }
                };

                Image productImage = new Image
                {
                    HeightRequest = 25,
                    WidthRequest = 25,
                    Aspect = Aspect.AspectFill,
                    HorizontalOptions = LayoutOptions.Start
                };
                productImage.SetBinding(Image.SourceProperty, "ImageUrl");


                Label priceLabel = new Label
                {
                    HorizontalOptions = LayoutOptions.End,
                    FontSize = 15,
                    FontAttributes = FontAttributes.Bold,
                    TextColor = Colors.Green
                };
                priceLabel.SetBinding(Label.TextProperty, "Price");

                HorizontalStackLayout hstack = new HorizontalStackLayout
                {
                    Padding = new Thickness(20, 10, 20, 10),
                    Spacing = 15,
                    //HeightRequest = 40,
                    Children =
                    {
                        productImage, vstack, priceLabel
                    }
                };
            }
        }
    }
}
