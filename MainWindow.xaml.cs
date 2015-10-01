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
using Journal2.Classes;

namespace Journal2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Journal currentJournal;

        public MainWindow()
        {
            InitializeComponent();
        }


        class MyJournalEntries{
          
            JournalEntry newEntry = new JournalEntry;
        }

        class Dates
        {
            DateTime currentDate = DateTime.Now;
            new.EntryDate = currentDate;
        }

        class Titles
        {
            this.Title = journalTitle;
        }

        class Publish
        {

        }
    }
}
