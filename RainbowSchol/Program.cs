using System;
using System.IO;
namespace RainbowSchol
{
    class Program
    {
        static void Main(string[] args)
        {
            char order;
            Console.WriteLine("Hello ! ");
            Console.WriteLine();

            Console.WriteLine("What do you want to do ? \n If you want to Store new data enter N , Retrive data enter R , Update data enter U ");
            order = Convert.ToChar(Console.ReadLine());

            Console.WriteLine();
            switch (order)
            {
                case 'N':
                    StoreNewData();
                    break;
                case 'R':
                    RetriveData();
                    break;
                case 'U':
                    UpdateData();
                    break;

            }
        }
        static void StoreNewData()
        {

            string FileName = "TeacherData.txt";
            string FilePath = @"C:\Demo\TeacherData.txt";

            // create-write in File 

            using (StreamWriter writer = File.CreateText(FileName))
            {
                writer.WriteLine("ID , Name , Class , Section ");

            }
            Console.WriteLine();


            int id;
            string name, clas, section, newAppend;
            //Append file content
            Console.WriteLine("Enter new Teacher Data (ID , Name , Class , Section) : ");
            Console.Write(" ID : ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Name : ");
            name = Convert.ToString(Console.ReadLine());
            Console.Write(" Class : ");
            clas = Convert.ToString(Console.ReadLine());
            Console.Write(" Section : ");
            section = Convert.ToString(Console.ReadLine());
            Console.WriteLine();

            newAppend = ("\n" + id + " , " + name + " , " + clas + " , " + section);
            File.AppendAllText(FilePath, newAppend);

            Console.WriteLine();
            //Display 
            string txtcontent2 = File.ReadAllText(FilePath);
            Console.WriteLine(txtcontent2);
            Console.WriteLine();
            Console.WriteLine("Store new Data Successfully ! ");


        }

        static void RetriveData()
        {
            string FilePath = @"C:\Demo\TeacherData.txt";


            Console.WriteLine("Do you want to retrive specific teacher enter 'S' or all teacher enter 'A' ");
            char r = Convert.ToChar(Console.ReadLine());
            if (r == 'S')
            {
                Console.WriteLine("Please enter the ID that you want to Retive his/her data ");
                string keyword = Console.ReadLine() ?? FilePath;
                Console.WriteLine();
                using (StreamReader sr = new StreamReader(FilePath))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        if (line.IndexOf(keyword, StringComparison.CurrentCultureIgnoreCase) >= 0)
                        {
                            Console.WriteLine(line);
                        }
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Retriving Data Successfully");
            }
            else
            {
                string txtcontent = File.ReadAllText(FilePath);
                Console.WriteLine(txtcontent);

            }

        }

        static void UpdateData()
        {
            string FilePath = @"C:\Demo\TeacherData.txt";

            Console.WriteLine("Enter the ID that you want to Update his/her data");

            string updById = Console.ReadLine() ?? FilePath;
            Console.WriteLine();
            using (StreamReader sr = new StreamReader(FilePath))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();

                    if (line.IndexOf(updById, StringComparison.CurrentCultureIgnoreCase) >= 0)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Retriving data Successfully");
            Console.WriteLine();

            Console.WriteLine("What do you want to update ? \n Name ? enter N , Class ? enter C , Section ? enter S ");
            char change = Convert.ToChar(Console.ReadLine());

            string print;
            string retname, oldname;
            switch (change)
            {
                case 'N':
                    Console.WriteLine("Enter the Old Name :");
                    oldname = Convert.ToString(Console.ReadLine());

                    Console.WriteLine("Enter the New Name :");
                    retname = Convert.ToString(Console.ReadLine());
                    using (StreamReader sr = new StreamReader(FilePath))
                    {

                        string line2 = sr.ReadLine();
                        if (line2.Contains(oldname))
                        {
                            print = line2.Replace(oldname, retname);

                            Console.WriteLine("After Update : " + print);
                            Console.WriteLine();
                            Console.WriteLine("Updated Data Successfully! ");
                            sr.Close();
                            File.WriteAllText(FilePath, print);
                        }

                    }

                    break;
                case 'C':
                    Console.WriteLine("Enter the Old Class :");
                    oldname = Convert.ToString(Console.ReadLine());

                    Console.WriteLine("Enter the New Class :");
                    retname = Convert.ToString(Console.ReadLine());
                    using (StreamReader sr = new StreamReader(FilePath))
                    {

                        string line2 = sr.ReadLine();
                        if (line2.Contains(oldname))
                        {
                            print = line2.Replace(oldname, retname);

                            Console.WriteLine("After Update : " + print);
                            Console.WriteLine();
                            Console.WriteLine("Updated Data Successfully! ");
                            sr.Close();
                            File.WriteAllText(FilePath, print);
                        }

                    }
                    break;
                case 'S':
                    Console.WriteLine("Enter the Old Section :");
                    oldname = Convert.ToString(Console.ReadLine());

                    Console.WriteLine("Enter the New Section :");
                    retname = Convert.ToString(Console.ReadLine());

                    using (StreamReader sr = new StreamReader(FilePath))
                    {

                        string line2 = sr.ReadLine();
                        if (line2.Contains(oldname))
                        {
                            print = line2.Replace(oldname, retname);

                            Console.WriteLine("After Update : " + print);
                            Console.WriteLine();
                            Console.WriteLine("Updated Data Successfully! ");
                            sr.Close();
                            File.WriteAllText(FilePath, print);
                        }

                    }
                    break;

            }
        }


    }
}
