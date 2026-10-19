namespace MauiLab4;

public class CompanyPage : ContentPage
{
	public CompanyPage()
	{

        Label mainLabel= new Label
        {
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center,
            FontSize = 40,
            Text = "Welcome to the Food Company Page!"
        };
        Label descriptionLabel = new Label
        {
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center,
            FontSize = 30,
            Text = "We produce all types of food, inlcuding hot dogs, tacos and hamburgers! We have been in business for over 20 years."
        };

        Content = new VerticalStackLayout
        {
            Spacing = 10,
            Children = {
                mainLabel, descriptionLabel, 
            }
        };

	}
}