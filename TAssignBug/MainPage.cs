using CommunityToolkit.Maui.Markup;
using System.Runtime.CompilerServices;

namespace TAssignBug
{
    public class MainPage : ContentPage
    {
        private MyLabel lb;

        private MyEntry et;
        public MainPage()
        {
            Content = new VerticalStackLayout
            {
                Children =
                {
                    new MyLabel
                    {

                    }.TextCenter()
                    .Assign(out lb),

                    new MyEntry
                    {

                    }.TextCenter()
                    .Assign(out et)
                }
            };
        }
    }

    public class MyLabel : Label
    {

    }

    public class MyEntry : Entry
    {

    }
}
