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
using System.Windows.Shapes;
using System.IO;

namespace WPF__Zavěrečná_práce
{
    /// <summary>
    /// Interakční logika pro AddTask.xaml
    /// </summary>
    public partial class AddTask : Window
    {
        public AddTask()
        {
            InitializeComponent();
            DataContext = new Tasks();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {

            string path = TextBoxName.Text + ".txt";
            if (TextBoxName.Text == "" || TextBoxDescription.Text == "" || ComboBoxMonth.SelectedIndex == -1 || ComboBoxDay.SelectedIndex == -1)
            {
                MessageBox.Show("Can't be empty!");
                return;
            }
            Tasks.AllTasks.Add((Tasks)DataContext);          
            string[] lines =
            {
                TextBoxName.Text, ComboBoxMonth.Text, ComboBoxDay.Text, TextBoxDescription.Text
            };
            File.WriteAllLines(path, lines);


            using (StreamWriter sw = File.AppendText("Note_List.txt"))
            {
                sw.WriteLine(path);
            }
            
             this.Close();
        }
        
    }
}
