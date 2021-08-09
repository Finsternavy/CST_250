using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeopleFileIO
{
    public partial class Form1 : Form
    {
        List<Person> people = new List<Person>();
        List<string> peopleProperties = new List<string>();

        BindingSource peopleListBinding = new BindingSource();

        string filePath = @"C:\demos\PeopleFileIOSavedFile.txt";


        public Form1()
        {
            InitializeComponent();
            setBindings();
        }

        private void setBindings()
        {
            peopleListBinding.DataSource = people;
            listBox1.DataSource = peopleListBinding;
            listBox1.DisplayMember = "name";
        }

        private void addToListButton_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            person.name = nameTextBox.Text;
            person.game = gameTextBox.Text;
            person.url = urlTextBox.Text;

            people.Add(person);

            peopleListBinding.ResetBindings(false);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            List<string> outputLines = new List<string>();

            foreach(Person person in people)
            {
                outputLines.Add(person.name + ", " + person.game + ", " + person.url);
            }

            string outPath = @"C:\demos\PeopleFileIOSavedFile.txt";
            File.WriteAllLines(outPath, outputLines);
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            people.Clear();

            string[] lines = File.ReadAllLines(filePath);

            int lineNumber = 1;
            List<int> errorLines = new List<int>();

            foreach (string line in lines)
            {
                char delimiter = ',';
                int frequency = Regex.Matches(line, delimiter.ToString()).Count;
                

                if(frequency == 2)
                {
                    string[] entries = line.Split(',');

                    Person person = new Person();
                    person.name = entries[0];
                    person.game = entries[1];
                    person.url = entries[2];

                    people.Add(person);
                    peopleListBinding.ResetBindings(false);
                    lineNumber++;
                }
                else
                {
                    errorLines.Add(lineNumber);
                    lineNumber++;
                }

                
            }
            // hold all error lines for messagebox message
            StringBuilder SB = new StringBuilder();

            foreach(int errorLineNumber in errorLines)
            {
                SB.Append("Line " + errorLineNumber.ToString() + " failed to load due to incorrect format in " + filePath + "\n" );
            }

            MessageBox.Show(SB.ToString());
        }
    }
}
