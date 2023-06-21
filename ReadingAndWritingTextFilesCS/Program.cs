using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadingAndWritingTextFilesCS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader fileToRead = new StreamReader("U:/Demo.txt");

            // Read the whole file to the console
            Console.WriteLine(fileToRead.ReadToEnd());
            
            fileToRead.Close(); // close after use 
            fileToRead = new StreamReader("U:/Demo.txt");//open file again ready to read at the beginning

            // Read a single line to the console
            Console.WriteLine(fileToRead.ReadLine());
            fileToRead.Close(); // close after use 
            fileToRead = new StreamReader("U:/Demo.txt");//open file again ready to read at the beginning

            // Read the file line by line until the end and output each line to the console
            do
            {
                Console.WriteLine(fileToRead.ReadLine());

            } while (!fileToRead.EndOfStream);

            fileToRead.Close(); // close after use 
            fileToRead = new StreamReader("U:/Demo.txt");//open file again ready to read at the beginning

            string fileContent = fileToRead.ReadToEnd();


            fileToRead.Close(); // close after use 
            fileToRead = new StreamReader("U:/Demo.txt");//open file again ready to read at the beginning

            string[] fileContents = new string[3]; // create an array to store each line
            // You would need to know the number of lines to do this!
            int counter = 0;
            do
            {
                fileContents[counter] = fileToRead.ReadLine();
                counter++;
            } while (counter < 3);


            // Writing to a new text file or overwriting existing one
            StreamWriter fileToWrite = new StreamWriter("U:/newTextFile.txt");
            fileToWrite.WriteLine("Some text added to a file");
            string output  = "This text written needs to be written to file";
            fileToWrite.WriteLine(output);
            fileToWrite.Close(); // saves the file

            //Writing to an existing text file and choosing to overwrite or not
            StreamWriter addToTextFile = new StreamWriter("U:/existingText.txt", true); // true means append (add to end)
            addToTextFile.WriteLine("A line of text");
            addToTextFile.WriteLine("and another");
            addToTextFile.Close(); // saves the changes to the file

        }
    }
}
