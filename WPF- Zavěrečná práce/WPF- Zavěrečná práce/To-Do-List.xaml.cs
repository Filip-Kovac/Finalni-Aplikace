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
    /// Interakční logika pro To_Do_List.xaml
    /// </summary>
    public partial class To_Do_List : Window
    {
        public To_Do_List()
        {
            InitializeComponent();
            Tasks.InitTasks();
            Tasks t = new Tasks();
            DataContext = t;
        }
        private void Tasks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Tasks ti = (Tasks)((sender as ListView).SelectedItem);
            DataContext = ti;

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            TasksList.SelectedIndex = 0;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            AddTask ad = new AddTask();
            ad.ShowDialog();
        }

        private void DoneButton_Click(object sender, RoutedEventArgs e)
        {
            if (TasksList.SelectedIndex == -1)
            {
                MessageBox.Show("You need to choose task!");
                return;
            }
            
                string s = Tasks.AllTasks[TasksList.SelectedIndex].Name;
                File.Delete(s + ".txt");
                File.Delete("Note_List.txt");
                int selected = TasksList.SelectedIndex;
                int count = Tasks.AllTasks.Count();
                for (int i = 0; i < count; i++)
                {
                    if (i != selected)
                    {
                        using (StreamWriter sw = File.AppendText("Note_List.txt"))
                        {
                            sw.WriteLine(Tasks.AllTasks[i].Name + ".txt");
                        }
                    }
                }
                if (File.Exists("Note_List.txt") == false)
                {
                    File.Create("Note_List.txt");
                }
                Tasks.AllTasks.Clear();
                Tasks.InitTasks();
                Tasks t = new Tasks();
                DataContext = t;
            


        }

    }
}
