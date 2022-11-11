using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture_13_Lists_Continued
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PreloadStudents();

            // Call DTExample
            //DTExample();

            //LSExample();



        }


        private void btnGrade_Click(object sender, EventArgs e)
        {
            int usersGrade = int.Parse(txtGrade.Text);

            Student student = FindStudentByGrade(usersGrade, students);

            if (student != null)// If zach is not null, means students was found
            {
                // CLearing our txtbox
                rtbDisplay.Text = "";
                rtbDisplay.Text += $"Student Name: {student.Name}\n";
                rtbDisplay.Text += $"Student Grade: {student.Grade}";
            }
            else
            {
                rtbDisplay.Text = "Student not found";
            }

        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Getting users input for name
            string userInput = txtStudentName.Text;

            StudentSearchExample(userInput);
        }

        string[] names =
        {
            "Hannah",
            "Zach",
            "Lesley",
            "Wong",
            "Will",
            "Sam"
        };


        int[] grades =
        {
            100,
            99,
            105,
            102,
            56,
            108
        };

        List<Student> students = new List<Student>();

        public void StudentSearchExample(string name)
        {
            Student student = FindStudentByName(name, students);

            if(student != null)// If zach is not null, means students was found
            {
                // CLearing our txtbox
                rtbDisplay.Text = "";
                rtbDisplay.Text += $"Student Name: {student.Name}\n";
                rtbDisplay.Text += $"Student Grade: {student.Grade}";
            } 
            else
            {
                rtbDisplay.Text = "Student not found";
            }
        }

        public void PreloadStudents()
        {
            students.Add(new Student("Sam", 100));
            students.Add(new Student("Hannah", 101));
            students.Add(new Student("Will", 56));
            students.Add(new Student("Lesley", 102));
            students.Add(new Student("Zach", 103));
            students.Add(new Student("Wong", 104));
        }

        // Finding the student by their name
        public Student FindStudentByName(string name, List<Student> list)
        {
            foreach (Student student in list)
            {
                // Current name of student
                string studentName = student.Name;

                // If name == name searched for
                if (studentName == name)
                {
                    // Return reference
                    return student;
                }
            }

            return null; // If student not found
        }

        // Find a student by their grade
        public Student FindStudentByGrade(int grade, List<Student> list)
        {
            foreach (Student student in list)
            {
                // Current grade of student
                int studentGrade = student.Grade;

                // If studentGrade == grade - return student
                if (studentGrade == grade)
                {
                    // Return reference
                    return student;
                }
            }

            return null; // If student not found
        }

        // Linear Search
        // Look through a list and tell us if the name is on the list
        // Two Paremeters - What to search, what to look through
        public bool LinearSearch(string search, string[] array)
        {
            // Loops through our array
            foreach (string item in array)
            {
                // Compares the current item with what
                // we are searching for
                // If true - returns true
                // If false - continues searching

                // Use built in c# methods to control case sensitivity
                // .ToUpper and .ToLower
                if(search.ToLower() == item.ToLower())
                {
                    return true;
                }      
            }
            // If not found - returns false
            // False only runs after entire list is searched
            return false;
        }

        /// <summary>
        /// Do a linear search for a value, returns the index or -1 if not found
        /// </summary>
        /// <param name="search">Value to search for</param>
        /// <param name="array">List to search</param>
        /// <returns>Index if found, -1 if not</returns>
        public int FoundAtIndex(string search, string[] array)
        {
            // Building for loop, because we need the index
            for (int i = 0; i < array.Length; i++)
            {
                // Holds current item
                string name = array[i];

                // If current item == search - return the index it's found at
                // Else keep searching
                if(name == search)
                {
                    return i;
                } // end of if

            } // end of loop

            return -1; // if not found, return -1
        }

        // Linear Search Example
        public void LSExample()
        {
            // What we are searching for
            string search = "Wong";

            // If it is found
            //bool isFound = LinearSearch(search, names);
            int indexOf = FoundAtIndex(search, names);

            // How to respond
            if(indexOf != -1)
            {
                rtbDisplay.Text = $"{names[indexOf]} is getting {grades[indexOf]}";
            }
            else
            {
                rtbDisplay.Text = $"{search} was NOT the list";

            }
        }




        #region DateTime
        // DateTime Object Example
        public void DTExample()
        {
            // Date Time Object
            DateTime dt = new DateTime();

            // date time tostring()
            // displays 01/01/0001 12a
            //rtbDisplay.Text = dt.ToString();

            //rtbDisplay.Text = dt.Minute.ToString();
            //rtbDisplay.Text = dt.Year.ToString();

            // Declaring a variable to hold todays date
            DateTime today = DateTime.Today;

            // Using DateTime.Today returns todays date
            // Does not return current time
            //rtbDisplay.Text = today.ToString();

            // .DayofWeek returns which day it is ( mon, tues )
            //rtbDisplay.Text = today.DayOfWeek.ToString();

            // Returns the day of a 365/6 year
            //rtbDisplay.Text = today.DayOfYear.ToString();

            // Returns the number of ticks since 01010001
            //rtbDisplay.Text = today.Ticks.ToString();

            // Returns if time is Local, UTC, or neither
            //rtbDisplay.Text = today.Kind.ToString();

            // How to access DateTime.Today

            // TOShortDate displays mm/dd/yyyy
            rtbDisplay.Text = today.ToShortDateString();


            // TOShortDate displays weekofDay, mm/dd/yyyy
            rtbDisplay.Text = today.ToLongDateString();

            // TOShortDate displays weekofDay, mm/dd/yyyy
            rtbDisplay.Text = today.ToShortTimeString();

            DateTime now = DateTime.Now;
            rtbDisplay.Text = now.ToString();

            // DateTime.Now returns day AND time
            // DateTime.Today returns just todays date
        }



        #endregion DateTime

        // List


    }
}
