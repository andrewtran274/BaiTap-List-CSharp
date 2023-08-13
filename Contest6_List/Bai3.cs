using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Tạo một danh sách các chuỗi và thực hiện phân loại chúng theo độ dài,
//tạo danh sách con chứa các chuỗi cùng độ dài.

namespace Contest6_List
{
    internal class Bai3
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>()
            {

                "Java", "CSharp", "PHP", "JavaScript", "C++", "HTML", "CSS", "TypeScript", "C", "NodeJs", "Python", "Dart"
            };
            Console.WriteLine("Danh Sach Cac Ngon Ngư Lap Trinh: ");
            foreach (string item in list)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            Console.WriteLine($"Danh Sach Cac Ngon Ngu Da Duoc Chia Nhom Theo Do Dai Ten: ");

            List<List<string>> GroupByNameLength = GroupByLength(list);

            foreach (List<string> item in GroupByNameLength)
            {
                Console.WriteLine($"Do Dai {item[0].Length} Ki Tu: ");
                foreach (string x in item)
                {
                    Console.WriteLine($"{x}");
                }
                Console.WriteLine();
            }
        }

        static List<List<string>> GroupByLength(List<string> list)
        {
            List<List<string>> sortByLength = new List<List<string>>();

            list.Sort((x, y) => x.Length.CompareTo(y.Length));


            int curentIndex = 0;

            while(curentIndex < list.Count)
            {
                int currenLength = list[curentIndex].Length;

                List<string> subGroup = new List<string>();
                while(curentIndex < list.Count && currenLength == list[curentIndex].Length) {
                    subGroup.Add(list[curentIndex]);
                    curentIndex++;
                }

                sortByLength.Add(subGroup);
            }

            return sortByLength;
        }
    }
}
