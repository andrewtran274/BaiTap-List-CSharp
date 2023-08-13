using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;


//Tạo một danh sách các từ và sắp xếp chúng
//theo thứ tự dài nhất đến ngắn nhất.

namespace Contest6_List
{
    internal class Bai1
    {
        static void Main(string[] args)
        {
            int compare(string s1, string s2)
            {
                if(s1.Length < s2.Length)
                {
                    return 1;
                }
                else if (s1.Length > s2.Length)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
            List<string> list = new List<string>() { "Java", "CSharp", "HTML&CSS", "JavaScript"};
            List<string> words = new List<string>
        {
            "apple", "banana", "grape", "pineapple", "orange", "kiwi"
        };
            list.Sort(compare);
            words.Sort(compare);

            Console.WriteLine("List Dau Tien: ");
            foreach (string s in list)
            {
                Console.Write($"{s} ");
            
            }
            Console.WriteLine();
            Console.WriteLine("List Thu 2: ");
            foreach(string s in words) {
                Console.Write($"{s} ");
            }
            Console.WriteLine();
        }
    }
}
