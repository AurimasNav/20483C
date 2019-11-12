using System;
using System.Globalization;
using System.Windows;

namespace School
{
    /// <summary>
    /// Interaction logic for StudentForm.xaml
    /// </summary>
    public partial class StudentForm : Window
    {
        #region Predefined code

        public StudentForm()
        {
            InitializeComponent();
        }

        #endregion

        // If the user clicks OK to save the Student details, validate the information that the user has provided
        private void ok_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Exercise 2: Task 2a: Check that the user has provided a first name
            if (string.IsNullOrEmpty(firstName.Text))
            {
                MessageBox.Show("The student must have a frist name", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (string.IsNullOrEmpty(lastName.Text))
            {
                MessageBox.Show("The student must have a last name", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }



            if (string.IsNullOrEmpty(dateOfBirth.Text) || !(DateTime.TryParse(dateOfBirth.Text, out _)))
            {
                MessageBox.Show("Must be valid date", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            TimeSpan Age = DateTime.Now.Subtract((DateTime.Parse(dateOfBirth.Text, CultureInfo.InvariantCulture, DateTimeStyles.AssumeLocal)));            // TODO: Exercise 2: Task 2b: Check that the user has provided a last name
            if ((Age.TotalDays / 365.25) < 5)
            {
                MessageBox.Show("The student must be at least 5 years old", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            // TODO: Exercise 2: Task 3a: Check that the user has entered a valid date for the date of birth
            // TODO: Exercise 2: Task 3b: Verify that the student is at least 5 years old

            // Indicate that the data is valid
            this.DialogResult = true;
        }
    }
}
