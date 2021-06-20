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
using System.IO;

namespace WPF__Zavěrečná_práce
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ButtonLogin_Click(object sender, RoutedEventArgs e)
        {
            using (var sr = new StreamReader("LogIn.txt"))
            {
                string name;
                string password;
                while ((name = sr.ReadLine()) != null)
                {
                    password = sr.ReadLine();
                    if (name == NameLogIn.Text && password == PasswordLogIn.Text)
                    {
                        
                        To_Do_List tdl = new To_Do_List();
                        this.Close();
                        tdl.ShowDialog();
                        
                        
                    }
                    else
                    {
                        MessageBox.Show("Wrong name or password." +
                            "\nJmeno.Prijmeni"+
"\nHeslo123");
                    }
                    name = null;
                }
            }




        }
    }
}
