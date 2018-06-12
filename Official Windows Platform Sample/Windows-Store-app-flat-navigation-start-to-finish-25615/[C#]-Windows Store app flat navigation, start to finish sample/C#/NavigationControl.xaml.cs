using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace FlatNavTemplate
{
    public sealed partial class NavigationControl : UserControl
    {
        public NavigationControl()
        {
            this.InitializeComponent();
        }

        private void NavButton_Click(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            Frame rootFrame = Window.Current.Content as Frame;

            if (b != null && b.Tag != null)
            {
                Type pageType = Type.GetType(b.Tag.ToString());

                // Make sure the page type exists, but don't navigate to it if it's already the current page.
                if (pageType != null && rootFrame.CurrentSourcePageType != pageType)
                {
                    (App.Current as App).Navigate(pageType);
                }
                else if (pageType == null)
                {
                    // TODO: Optional - Do something if page not found.
                }
            }
        }
    }
}
