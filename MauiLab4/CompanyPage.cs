namespace MauiLab4;

public class CompanyPage : ContentPage
{
	public CompanyPage()
	{
		Content = new VerticalStackLayout
		{
			Children = {
				new Label { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, Text = "Welcome to the Food Company Page!"
				}
			}
		};
	}
}