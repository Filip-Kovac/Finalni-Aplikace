using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;

namespace WPF__Zavěrečná_práce
{
    public class Tasks : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string name;
        public string Name
        {
            get => name;
            set { name = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name")); }
        }

        private string deadline;
        public string Deadline
        {
            get => deadline;
            set { deadline = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Deadline")); }
        }

        private string day;
        public string Day
        {
            get => day;
            set { day = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Day")); }

        }

        private string description;
        public string Description
        {
            get => description;
            set { description = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Description")); }

        }



        public static ObservableCollection<Tasks> AllTasks
        { get; set; } = new ObservableCollection<Tasks>();

        public static void InitTasks()
        {
            var sr = new StreamReader("Note_List.txt");
            string note;
            while ((note = sr.ReadLine()) != null)
            {
                if(note != "")
                        {
                    using (var sr1 = new StreamReader(note))
                    {
                        AllTasks.Add(new Tasks
                        {
                            Name = sr1.ReadLine(),
                            Deadline = sr1.ReadLine(),
                            Day = sr1.ReadLine(),
                            Description = sr1.ReadToEnd(),

                        });
                    }
                }
            } 




        }

    }
}
