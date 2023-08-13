using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Tạo một danh sách các phần tử số nguyên và sắp xếp chúng
//theo thứ tự tăng dần, nhưng các số chẵn được đưa lên trước.

namespace Contest6_List
{
    internal class Bai2
    {
        static void Main(string[] args)
        {
            int compare(int x, int y)
            {
                if (x % 2 == 0 && y % 2 == 0)
                {
                    if(x > y)
                    {
                        return 1;
                    }
                    else if (x < y)
                    {
                        return -1;
                    }
                    else
                    {
                        return 0;
                    }
                    
                } else if (x % 2 == 0 && y % 2 != 0)
                {
                    return -1;
                }else if(x % 2 != 0 && y % 2 != 0)
                {
                    if(x > y)
                    {
                        return 1;
                    }
                    else if(x < y)
                    {
                        return -1;
                    }
                    else
                    {
                        return 0;
                    }
                }else if(x % 2 != 0 && y % 2 == 0) {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }

            List<int> list = new List<int>() { 2, 6,7,9,10,15,26,4,5,8};

            list.Sort(compare);
            foreach (int i in list)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}
