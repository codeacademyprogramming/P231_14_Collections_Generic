using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ArrayList arrayList = new ArrayList();

            arrayList.Add(1);
            arrayList.Add(45);
            arrayList.Add(65);
            arrayList.Add("hikmet");
            arrayList.Add('a');

            arrayList.RemoveAt(2);


            ArrayList newArrList = new ArrayList();
            newArrList.AddRange(arrayList);

            newArrList.Add(100);
            newArrList.Add('N');

            newArrList.Reverse();

            Console.WriteLine(arrayList.Count);

            foreach (var item in newArrList)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine(" ========= Queue =========");
            Queue queue = new Queue();

            queue.Enqueue(10);
            queue.Enqueue('a');
            queue.Enqueue("Hikmet");

            Console.WriteLine($"siradaki: {queue.Peek()}");
            queue.Dequeue();



            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(" ========= Stack =========");

            Stack stack = new Stack();

            stack.Push(11);
            stack.Push(22);
            stack.Push(34);
            stack.Push("10");
            stack.Push("30");
            stack.Push('A');

            Console.WriteLine($"siradaki: {stack.Peek()}");
            Console.WriteLine($"siradan cixan: {stack.Pop()}");
            Console.WriteLine($"siradan cixan: {stack.Pop()}");


            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            SortedList sortedList = new SortedList();

            sortedList.Add("N14", "Hikmet");
            sortedList.Add("A15", 'd');
            sortedList.Add("A12", 23);

            Console.WriteLine(sortedList["110"]);

            List<Student> list = new List<Student>();

            var std = new Student { GroupNo = "P123", Name = "Nermin" };

            list.Add(new Student() { GroupNo = "P111",Name = "Abbas"});
            list.Add(std);
            list.Add(std);

            list.RemoveAt(1);
            list.Remove(std);



            foreach (Student item in list)
            {
                Console.WriteLine(item);
            }


            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("N14", "Hikmet1");
            students.Add("N15", "Hikmet2");
            students.Add("N10", "Hikmet3");
            students.Add("N17", "Hikmet4");



            foreach (var item in students)
            {
                Console.WriteLine(item.Key+" - "+item.Value);
            }


            students.Remove("N10");



            SortedList<string, string> sortedListGen = new SortedList<string, string>();

            sortedListGen.Add("A1", "Mercedec");
            sortedListGen.Add("B2", "BMW");
            sortedListGen.Add("B1", "Audi");
            sortedListGen.Add("11", "Opel");

            foreach (var item in sortedListGen)
            {
                Console.WriteLine(item.Key+" - "+item.Value);
            }

            Dictionary<string, double> groups = new Dictionary<string, double>();
            groups.Add("P123", 87);
            groups.Add("P124", 77);
            groups.Add("P231", 17);
            groups.Add("D202", 27);

            double sum = 0;
            foreach (var item in groups)
            {
                sum += item.Value;
            }

            var result = sum / groups.Count;


            List<Group> groupList = new List<Group>();

            groupList.Add(new Group { No = "P111", AvgPoint = 65 });
            groupList.Add(new Group { No = "P112", AvgPoint = 95 });
            groupList.Add(new Group { No = "P113", AvgPoint = 15 });
            groupList.Add(new Group { No = "D111", AvgPoint = 55 });

            

            sum = 0;
            int count = 0;
            foreach (Group gr in groupList)
            {
                if (gr.AvgPoint >= 65)
                {
                    sum += gr.AvgPoint;
                    count++;
                }
            }

            result = sum / groupList.Count;

            Console.WriteLine(result);



            List<int> nums = new List<int>();

        




            Console.WriteLine(nums.Count);
            Console.WriteLine(nums.Capacity);








        }
    }
}
