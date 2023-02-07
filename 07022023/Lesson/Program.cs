using System;

namespace Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStringList arr = new MyStringList();
                

            arr.Add("str1");
            arr.Add("str2");
            arr.Add("str3");
            arr.Add("str4");


            foreach (var item in arr.Arr)
            {
                Console.WriteLine(item);
            }

            MyStringList names = new MyStringList();

            names.Add("Hikmet");
            names.Add("Nermin");
            names.Add("Tofiq");
            names.Add("Abbas");

            names.Remove(2);

            foreach (var item in names.Arr)
            {
                Console.WriteLine(item);
            }


            MyIntList numbers = new MyIntList();

            numbers.Add(15);
            numbers.Add(45);
            numbers.Add(-45);
            numbers.Add(5);
            numbers.Add(25);


            numbers.Remove(2);

            foreach (var item in numbers.Arr)
            {
                Console.WriteLine(item);
            }


            MyDoubleList myDoubleList = new MyDoubleList();

            MyList<string> strList = new MyList<string>();
            strList.Add("str");

            MyList<int> intList = new MyList<int>();

            intList.Add(45);

            DataStore<string, string> values = new DataStore<string, string>();

            values.Add("N13", "Hikmet Abbasov");
            values.Add("N45", "Nermin Abbasova");

            var name = values.GetValue("N45");

            KeyValuePair<string, int> point = new KeyValuePair<string, int>();
            point.Key = "Hikmet";
            point.Value = 78;







        }
    }
}
