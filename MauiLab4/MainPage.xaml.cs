namespace MauiLab4
{
    public partial class MainPage : ContentPage
    {
        public Product SelectedProduct { get; set; }
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


            Title = "Product List";

            myListView.ItemTemplate = new DataTemplate(typeof(ListofProductsCell));


            myListView.ItemTapped += async (sender, e) =>
            {
                SelectedProduct = (Product)e.Item;
                await DisplayAlertAsync("Item Selected", SelectedProduct.Name.ToString() +
                    " was selected.\nDescription: " + SelectedProduct.Description + "\nPrice: " + SelectedProduct.Price, "Confirm");
                ((ListView)sender).SelectedItem = null;
            };

            Button invoiceButton = new Button
            {
                Text = "Invoice",
                HorizontalOptions = LayoutOptions.Center,
                FontSize = 30,
                FontAttributes = FontAttributes.Bold,
                TextColor = Colors.White
            };
            invoiceButton.Clicked += async (sender, e) =>
            {
                if(SelectedProduct == null)
                {
                    await DisplayAlertAsync("Warning", "Please select a product first.", "Confirm");
                    return;
                }
                await Navigation.PushAsync(new InvoicePage(SelectedProduct));
            };
            Button companyInfoButton = new Button
            {
                Text = "Company Info",
                HorizontalOptions = LayoutOptions.Center,
                FontSize = 30,
                FontAttributes = FontAttributes.Bold,
                TextColor = Colors.White
            };
            companyInfoButton.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new CompanyPage());
            };



            HorizontalStackLayout buttonLayout = new HorizontalStackLayout
            {
                Padding = new Thickness(10, 0, 10, 0),
                Spacing = 10,
                Children =
                {
                    invoiceButton, companyInfoButton
                }
            };

            VerticalStackLayout mainLayout = new VerticalStackLayout
            {
                HorizontalOptions = LayoutOptions.Fill,
                Children =
                {
                    buttonLayout, myListView
                }

            };
            Content = mainLayout;
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
                    Padding = new Thickness(15, 10, 15, 0),
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
