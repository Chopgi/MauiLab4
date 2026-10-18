namespace MauiLab4;

public class InvoicePage : ContentPage
{
    public InvoicePage(Product SelectedProduct)
    {
        Image productImage = new Image
        {
            HeightRequest = 200,
            WidthRequest = 200,
            Aspect = Aspect.AspectFill,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center,
            Source = SelectedProduct.imageSource
        };

        Label priceLabel = new Label
        {
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center,
            FontSize = 30,
            FontAttributes = FontAttributes.Bold,
            TextColor = Colors.Green,
            Text = "Price: "+SelectedProduct.Price
        };
        Label descriptionLabel = new Label
        {
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center,
            Text = "You have selected the " + SelectedProduct.Name
        };


        Content = new VerticalStackLayout
        {
            Spacing = 10,
            Children = {
                descriptionLabel, productImage, priceLabel
            }
        };
    }
}