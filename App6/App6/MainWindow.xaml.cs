using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;


// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace App6
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();

            //// Set the initial content of the window to the Frame
            //Frame mainFrame = new Frame();
            //this.Content = mainFrame;

            //// Navigate to the initial page (could be a start page)
            //mainFrame.Navigate(typeof(BatteryConnected)); // You can set this to another initial page if needed
        }

        private void ActionButton_Click(object sender, RoutedEventArgs e)
        {
            Frame mainFrame = new Frame();
            mainFrame.Navigate(typeof(BatteryConnected));
            this.Content = mainFrame;

        }
    }
}
