using ConsoleApp1.CW;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CwArithmatic c1 = new CwArithmatic();

            // Console.WriteLine("enter 4 scores");
            //int s1 = int.Parse(Console.ReadLine());
            //int s2 = int.Parse(Console.ReadLine());
            //int s3 = int.Parse(Console.ReadLine());
            //int s4 = int.Parse(Console.ReadLine());

            // int[] scores = { s1,s2, s3, s4 };
            // c1.calc(scores);
            //Console.WriteLine("consoole2");
            //Patient p1 = new Patient();
            //p1.connsultant();

            //a.MyClass m = new a.MyClass();
            //b.MyClass m1 = new b.MyClass();
            //m.myMethod();
            //m1.myMethod();

            //MySampleClass m1 = new MySampleClass(10);
            //int res = m1.area();

            //Console.WriteLine(res);

            //Console.WriteLine(DOW.Sunday);

            //String st = "      Anirban Mondal";
            //String[] st2 = { "apple", "bananna", "pomegrnate", "orange", "guava" };
            //Console.WriteLine(st.Substring(0,3));
            //Console.WriteLine(st.Trim());
            //String[] res = st2.Split(',');
            //foreach (String item in res)
            //{
            //    Console.WriteLine(item.Trim());
            //}

            //String res = String.Join(",", st2);
            //Console.WriteLine(res);

            //String a1 = "1234";
            //Console.WriteLine(a1.PadRight(8, '_'));

            //Car c1 = new Car();
            //Maruti m = new Maruti();
            //BMW b = new BMW();
            //b.discount();

            //Car c1 = new Maruti(); //using base class reeference variable to pointing to the child class object
            //((Maruti)c1).running();


            //ConditionalGreet cg1 = new ConditionalGreet("", "night");
            //cg1.Greet();


            //string filePath = "example.txt";
            ////string[] lines = {
            ////"This is the first line.",
            ////"This is the second line.",
            ////"This is the third line."
            //String line = "hey there! I am Anirbanf.";
            //try
            //{
            //    //File.WriteAllLines(filePath, lines);
            //    //File.WriteAllText(filePath, line);
            //    File.AppendAllText(filePath,Environment.NewLine +  line);
            //    Console.WriteLine("Lines written to file.");
            //}
            //catch (IOException ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}

            //string dirPath = "newDirectory";
            //string filePath = "hello.txt";
            //string line = "hello from  admin";

            //try
            //{
            //    //// Create the directory if it doesn't exist
            //    //if (!Directory.Exists(dirPath))
            //    //{
            //    //    Directory.CreateDirectory(dirPath);
            //    //    Console.WriteLine("Directory created successfully.");
            //    //}
            //    //else
            //    //{

            //    //   File.AppendAllText(filePath, line);
            //    //    Console.WriteLine("done");
            //    //}

            //    if (File.Exists(filePath))
            //    {
            //        File.Delete(filePath);
            //        Console.WriteLine("FILE SUCCESSFULLY DELETED");
            //    } else
            //    {
            //        Console.WriteLine("FILE NOT FOUND");
            //    }
            //}
            //catch (IOException ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}


            //GenericExample.example();

            //Category c1 = new Category();
            Patient p1 = new Patient(1245,"Anirban Mondal",24,5.7F);
            p1.connsultant();


        }
    }
}
