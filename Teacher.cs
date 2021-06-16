using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace TeacherRecords
{
    class Teacher
    {
        // teacher variables and their default values 
        private string _teacherID = " ";
        private string name = " ";
        private string tclass = " ";
        private string section = " ";


        // constructor with no parameters
        public Teacher()
        {
            
        }

        // constructor with all the parameters
        public Teacher(string _teacherID, string name, string tclass, string section)
        {
            this._teacherID = _teacherID;
            this.name = name;
            this.tclass = tclass;
            this.section = section;


        }


        // encasulation of teacherID
        public string teacherID
        {
            get
            {
                return this._teacherID;
            }
            
        }

        public string tname
        {
            set
            {
                name = value;
            }
            get
            {
                return this.name;
            }
        }

        public string tClass
        {
            set
            {
                tclass = value;
            }
            get
            {
                return this.tclass;
            }
        }

        public string tsection
        {
            set
            {
                section = value;
            }
            get
            {
                return this.section;
            }
        }


        public void print()
        {
            Console.WriteLine("ID: " + teacherID + "\tName: " + this.name +"\tClass: " + tclass + "\tSection: " + section);
        }
        public void print(StreamWriter writer)
        {
            writer.WriteLine("ID: " + teacherID + "\tName: " + this.name + "\tClass: " + tclass + "\tSection: " + section);
        }
    }
}
