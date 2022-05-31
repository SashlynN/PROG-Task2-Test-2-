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

namespace JobApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Global Decleration of Object]
        Campus c = new Campus();
        public MainWindow()
        {
            InitializeComponent();
            c.lecturerFirstName = " ";
            c.lecturerSurname = " ";
            c.lecturerEmail = "user@example.com";
            c.lecturerCampusLocation = " ";
            c.midrandLocation = null;

            // create a data context 

            this.DataContext = c;//source of data 





        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            c.lecturerCampusLocation = " ";
            if (c.midrandLocation== "True")
            {
                c.lecturerCampusLocation = "Midrand";
            }
            if (c.SadntonLocation == "True")
            {
                c.lecturerCampusLocation = "Sandton";
            }
            if (c.DurbanLocation == "True")
            {
                c.lecturerCampusLocation = "Durban";
            }
            if (c.PretoriaLocation == "True")
            {
                c.lecturerCampusLocation = "Pretoria";
            }
            if (c.PortElizabethCampusLocation == "True")
            {
                c.lecturerCampusLocation = "Port Elizabeth";
            }
            if (c.eastLondonLocation == "True")
            {
                c.lecturerCampusLocation = "East london";
            }
           



            String Message = "\nLecturer Name: " + c.lecturerFirstName
                          + "\nLectuer Surname: " + c.lecturerSurname
                          + "\nLecturer Email: " + c.lecturerEmail
                          +"\nLecturer Degree: "+c.lecturerDegree
                          +"\nLecture Venue: "+ c.lecturerCampusLocation;

            MessageBox.Show("Your details are as follows"+Message);




        }
    }
}
