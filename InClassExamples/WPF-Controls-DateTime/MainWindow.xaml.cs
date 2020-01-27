// Trevor Bryant
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

namespace WPF_Controls_DateTime
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            txtlastName.Text = string.Empty;
            txtfirstName.Text = string.Empty;
            txtbirthDate.Text = string.Empty;
        }

        private void Btnsubmit_Click(object sender, RoutedEventArgs e)
        {

            string firstName, lastName, birthDate;
            firstName = txtfirstName.Text;
            lastName = txtlastName.Text;
            birthDate = txtbirthDate.Text;

            DateTime bday = DateTime.Now; // set it to the current date and time at this exact moment of execution
            bday = Convert.ToDateTime(birthDate);
            string fullName = firstName + " " + lastName;
            
            foreach (var letter in fullName)
            {
                lstLetters.Items.Add(letter);
            }

            string message = $"{fullName} born on {bday.DayOfWeek}, \n Thank you for submitting =)!";
            MessageBox.Show(message);
        }

        private void BtnClose1_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
