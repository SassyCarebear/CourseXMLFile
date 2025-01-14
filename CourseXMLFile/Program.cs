using System;
using System.IO;
using System.Collections.Generic;
using System.Xml.Serialization;
using static System.Environment;
using static System.Console;
using static System.IO.Path;



namespace CourseXMLFile
{
    class Program
    {
        static void Main(string[] args)
        {
            var course = new List<XmlCourse>
            {

                new XmlCourse() {CourseName = "CS150", Enroll= 180, Maximum = 200 },
                new XmlCourse() {CourseName = "CS250", Enroll = 21, Maximum = 30 },
                new XmlCourse() {CourseName = "CS270", Enroll = 9, Maximum = 20},
                new XmlCourse() {CourseName = "CS300", Enroll = 4, Maximum = 20},
                new XmlCourse() {CourseName = "CS350", Enroll = 20, Maximum = 20},
        };
            var xs = new XmlSerializer(typeof(List<XmlCourse>));  //XmlSerializer instance named xs

            //create File to write to
            string path = Combine(CurrentDirectory, "xmlcourse.xml");      // create xmlcourse.xml file in proj folder
            using (FileStream stream = File.Create(path))  //using opens the file, runs the body, and closes the file
            {
                xs.Serialize(stream, course);           //send it to the stream, using our people list
            }  //done serializing list

            WriteLine($"Written {new FileInfo(path).Length} bytes of XML to {path}");
            WriteLine(File.ReadAllText(path));
        }
    }
}
