using System;
using System.Collections.Generic;
using System.Text;

namespace MauiLab4
{
    public class GroupHeader : ViewCell
    {
        public GroupHeader()
        {
            
            Label groupName = new Label
            {
                FontSize = 22,
                TextColor = Colors.White,
                FontAttributes = FontAttributes.Bold,
                VerticalOptions = LayoutOptions.Center
            };
            groupName.SetBinding(Label.TextProperty, "GroupName");

            StackLayout stack = new StackLayout
            {
                Padding = new Thickness(15, 0, 0, 0),
                HorizontalOptions = LayoutOptions.Fill,
                MinimumHeightRequest = 40,
                BackgroundColor = Colors.Black,
                Orientation = StackOrientation.Horizontal,
                Children =
                {
                    groupName
                }
            };
            View = stack;

        }
    }
}
