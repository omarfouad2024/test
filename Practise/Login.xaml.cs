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

namespace Practise
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Signup_click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Signup());
        }

        private void Login_click(object sender, RoutedEventArgs e)
        {
            string name = Emailtext.Text;
            string password = passtext.Text;  
            if(name =="1" && password == "1")
            {
                NavigationService.Navigate(new Admin());
                MessageBox.Show("welcome Succefully ");
                return;
            }

             






        }
    }
}
