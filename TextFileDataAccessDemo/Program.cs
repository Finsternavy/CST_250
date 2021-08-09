using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace TextFileDataAccessDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\demos\text.txt";

            List<Person> people = new List<Person>();
            List<String> lines = File.ReadAllLines(filePath).ToList();
            lines.Add("This, line, should, return, an, error");
            lines.Add("Halifax, PUBG, twitch.tv/halifax");

            int errorCount = 0;
            int lineNumber = 1;
            List<int> errorLines = new List<int>();

            foreach (string line in lines)
            {
                char delimiter = ',';
                int frequency = Regex.Matches(line, delimiter.ToString()).Count;

                if(frequency == 2)
                {
                    string[] entries = line.Split(',');

                    Person p = new Person();
                    p.name = entries[0];
                    p.gameName = entries[1];
                    p.url = entries[2];

                    people.Add(p);
                    lineNumber++;
                }
                else
                {
                    errorLines.Add(lineNumber);
                    errorCount++;
                    lineNumber++;
                }
                
            }

            foreach(int line in errorLines)
            {
                Console.WriteLine("Line " + line + " was not read due to formatting error.");
            }


            // print a list of people and save to another file

            // output lines will be used to save to the file.
            List<string> outputLines = new List<string>();
            Console.WriteLine("Here is the list of people I have: ");
            foreach(Person person in people)
            {
                // first print to the console
                Console.WriteLine("Name: " + person.name + " Game: " + person.gameName + " URL: " + person.url);

                // add another line for the file output.
                outputLines.Add("Name: " + person.name + " Game: " + person.gameName + " URL: " + person.url + "\n");
            }

            // write to another file
            string outPath = @"C:\demos\peopleOut.txt";
            File.WriteAllLines(outPath, outputLines);

            Console.ReadLine();
        }
    }
}
