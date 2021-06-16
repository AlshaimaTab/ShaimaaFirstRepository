using System;
using System.Collections.Generic;
using System.IO;

namespace TeacherRecords
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Teacher> records = new List<Teacher>();


            string filename = "teacherRecordsText.txt";

            if (File.Exists(filename))
            {
                Console.WriteLine(filename + " file found!");

            }
            else
            {
                Console.WriteLine("File not found..");
            }
            

            Console.WriteLine("\nWelcome to rainbow school teacher storage system! what would you like to do? ");
            Boolean n = true;
            do
            {
                Console.WriteLine("\n1- Add new teacher data\n2- Retrieve teacher data\n3- Update teacher data\n4- view current teacher records\n5- Exit");
                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("\nYou chose to add new teacher... ");

                        Console.Write("\nEnter ID: ");
                        string ID = Console.ReadLine();
                        Console.Write("\nEnter name: ");
                        string name = Console.ReadLine();
                        Console.Write("\nEnter class: ");
                        string tclass = Console.ReadLine();
                        Console.Write("\nEnter section: ");
                        string section = Console.ReadLine();

                        Teacher t = new Teacher(ID, name, tclass, section);
                        records.Add(t);

                        Console.WriteLine("\nYou have added new teacher");
                        t.print();
                        break;
                    case "2":
                        Console.WriteLine("\nYou chose to retrieve teacher data... ");
                        Console.Write("\nEnter ID of teacher: ");
                        string key = Console.ReadLine();
                        for (int i = 0; i < records.Count; i++)
                        {
                            Teacher t1 = records[i];
                            string tid = t1.teacherID;
                            if (tid == key)
                            {
                                Console.WriteLine("\nTeacher found: ");
                                t1.print();
                                break;
                            }
                        }
                        Console.WriteLine("\nThere is no teacher with this ID in records... try again");
                        break;
                    case "3":
                        Console.WriteLine("\nYou chose to update teacher data... ");
                        Console.Write("\nEnter ID of teacher you wish to change: ");
                        key = Console.ReadLine();
                        int index = -1;
                        for (int i = 0; i < records.Count; i++)
                        {
                            Teacher t1 = records[i];
                            string tid = t1.teacherID;
                            if (tid == key)
                            {
                                Console.WriteLine("\nTeacher found: ");
                                t1.print();
                                index = i;
                                break;
                            }
                        }
                        if (index == -1)
                            Console.WriteLine("There is no teacher with this ID in records... try again");
                        else
                        {
                            Console.WriteLine("\n1- Update name\n2- Update class\n3- Update section\n4- Cancel");
                            string select = Console.ReadLine();
                            switch (select)
                            {
                                case "1":
                                    Console.Write("\nEnter name: ");
                                    string newName = Console.ReadLine();
                                    records[index].tname = newName;
                                    Console.WriteLine("\nUpdates made to this teacher record: ");
                                    records[index].print();
                                    break;
                                case "2":
                                    Console.Write("\nEnter class: ");
                                    string newClass = Console.ReadLine();
                                    records[index].tClass = newClass;
                                    Console.WriteLine("\nUpdates made to this teacher record: ");
                                    records[index].print();
                                    break;
                                case "3":
                                    Console.Write("\nEnter section: ");
                                    string newSection = Console.ReadLine();
                                    records[index].tsection = newSection;
                                    Console.WriteLine("\nUpdates made to this teacher record: ");
                                    records[index].print();
                                    break;
                                case "4":
                                    Console.WriteLine("\nUpdate request cancelled... ");
                                    break;
                                default:
                                    Console.WriteLine("\nThis is not a valid choice... sorry try again... ");
                                    break;
                            }
                        }

                        break;
                    case "4":
                        Console.WriteLine("\nTeacher records: ");
                        for(int i = 0; i < records.Count; i++)
                        {
                            Console.Write((i+1)+"- ");
                            records[i].print();
                        }
                        break;
                    case "5":

                        //Create/Write in Files to enter teacher records in file
                        using (StreamWriter writer = File.CreateText(filename))
                        {
                            writer.WriteLine("\nTeacher records: ");
                            for (int i = 0; i < records.Count; i++)
                            {
                                writer.Write((i + 1) + "- ");
                                records[i].print(writer);
                            }

                        }
                        Console.WriteLine("\nThank You for using Rainbow school teacher storage system!\nThe teacher list has been added to file...");
                        n = false;
                        break;
                    default:
                        Console.WriteLine("This is not a valid choice... sorry try again... ");
                        break;
                }
            } while (n == true);

        }
    }
}
