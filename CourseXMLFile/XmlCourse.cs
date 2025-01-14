using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Program:    Course Class
    Developer:  Cara Jones
    Date:       03/18/2022
    Purpose:    Ch.8 hands on project- Display what I've learned
*/
namespace CourseXMLFile
{
    public class XmlCourse
    {


        #region -------------PRIVATE ATTRIBUTES----------------
        private string courseName;
        private int enroll;
        private int maximum;
        #endregion

        #region -----------GETTERS AND SETTERS------------------
        public string CourseName { get { return courseName; } set { courseName = value; } }//end CourseName
        public int Enroll { get { return enroll; } set { enroll = value; } }//end Enroll
        public int Maximum { get { return maximum; } set { maximum = value; } }//end available
        #endregion

        #region -----------------CONSTRUCTORS------------------
        public XmlCourse()
        {

        }
        #endregion

    }//end of Class

}

