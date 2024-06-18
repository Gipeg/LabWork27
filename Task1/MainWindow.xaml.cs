using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Task1.Pages;
using System.Windows.Controls;
using static Task1.App;

namespace Task1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ContentFrame.Navigate(new Pages.MainPage());
            Manager.MainFrame = ContentFrame;
        }

        private void GoBackButton_Click(object sender, RoutedEventArgs e)
        {
            if (ContentFrame.CanGoBack)
                ContentFrame.GoBack();
        }

        private void ContentFrame_ContentRendered(object sender, EventArgs e)
        {
            if(ContentFrame.CanGoBack)
                GoBackButton.Visibility = Visibility.Visible;
            else
                GoBackButton.Visibility = Visibility.Collapsed;
        }
    }
}
