using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("qwe");
                Console.WriteLine("n = {0}", RomanToInt(Console.ReadLine())); //1
                //Console.WriteLine(BalanceParentheses(Console.ReadLine()) ? "true" : "false"); //2
                Console.WriteLine("key 'Esc' for exit");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);



            //DoubleLinkedNode<int> a = new DoubleLinkedNode<int>();
            //a.AddLast(23);
            //a.AddLast(24);
            //a.AddLast(25);
            //a.AddFirst(22);
            //a.Reverse();
        }


        #region 1
        public static int RomanToInt(string s){
            int n = 0;
            string simvol = "IVXLCDM";
        ////////////////////////////////////////////////////проверка числа
            for (int i = 0; i < s.Length; i++)
            {
                if ((s[i] != simvol[0]) && (s[i] != simvol[1]) && (s[i] != simvol[2]) && (s[i] != simvol[3]) && (s[i] != simvol[4]) && (s[i] != simvol[5]) && (s[i] != simvol[6]))
                {
                    Console.WriteLine("no1");
                    return 0;
                }             
            }
            for (int i = 0; i < s.Length-1; i++)
            {
                for (int j = 1; j<simvol.Length; j += 2)
                {
                    if (s[i] == simvol[j] && s[i+1] == simvol[j])
                    {
                        Console.WriteLine("no2");
                        return 0;
                    }
                }
            }
                for (int i = 0; i < s.Length-3; i++)
            {
                if ((s[i + 1] == s[i]) && (s[i + 2] == s[i]) && (s[i + 3] == s[i]))
                {
                    Console.WriteLine("no2");
                    return 0;
                }
                
            }
            if (s.Length == 0) { Console.WriteLine("no3"); return 0; }
            if ((s.Length > 3) && (s[0] == simvol[6]) && (s[1] == simvol[6]) && (s[2] == simvol[6])) { Console.WriteLine("no4"); return 0; }
        //////////////////////////////////////////////////// перевод числа
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == simvol[0]) { n += 1; continue; }
                if (s[i] == simvol[1]) { if ((i != 0) && (s[i - 1] == simvol[0])) { if ((i + 1 < s.Length) && (s[i + 1] == simvol[0])) { Console.WriteLine("no5"); return 0; } n -= 1; n += 5 - 1; } else { n += 5; } continue; }
                if (s[i] == simvol[2]) { if ((i != 0) && (s[i - 1] == simvol[0])) { if ((i + 1 < s.Length) && (s[i + 1] == simvol[0])) { Console.WriteLine("no5"); return 0; } n -= 1; n += 10 - 1; } else { n += 10; } continue; }
                if (s[i] == simvol[3]) { if ((i != 0) && (s[i - 1] == simvol[2])) { if ((i + 1 < s.Length) && (s[i + 1] == simvol[2])) { Console.WriteLine("no5"); return 0; } n -= 10; n += 50 - 10; } else { n += 50; } continue; }
                if (s[i] == simvol[4]) { if ((i != 0) && (s[i - 1] == simvol[2])) { if ((i + 1 < s.Length) && (s[i + 1] == simvol[2])) { Console.WriteLine("no5"); return 0; } n -= 10; n += 100 - 10; } else { n += 100; } continue; }
                if (s[i] == simvol[5]) { if ((i != 0) && (s[i - 1] == simvol[4])) { if ((i + 1 < s.Length) && (s[i + 1] == simvol[4])) { Console.WriteLine("no5"); return 0; } n -= 100; n += 500 - 100; } else { n += 500; } continue; }
                if (s[i] == simvol[6]) { if ((i != 0) && (s[i - 1] == simvol[4])) { if ((i + 1 < s.Length) && (s[i + 1] == simvol[4])) { Console.WriteLine("no5"); return 0; } n -= 100; n += 1000 - 100; } else { n += 1000; } continue; }
                if ((s[i + 1] == simvol[0]) && (s[i + 2] == simvol[0]) && (s[i + 3] == simvol[0])) { n += 3; i += 4; continue; }
                if ((s[i + 1] == simvol[2]) && (s[i + 2] == simvol[2]) && (s[i + 3] == simvol[2])) { n += 30; i += 4; continue; }
                if ((s[i + 1] == simvol[4]) && (s[i + 2] == simvol[4]) && (s[i + 3] == simvol[4])) { n += 300; i += 4; continue; }
                if ((s[i + 1] == simvol[0]) && (s[i + 2] == simvol[0])) { n += 2; i += 3; continue; }
                if ((s[i + 1] == simvol[2]) && (s[i + 2] == simvol[2])) { n += 20; i += 3; continue; }
                if ((s[i + 1] == simvol[4]) && (s[i + 2] == simvol[4])) { n += 200; i += 3; continue; }
                if ((s[i + 1] == simvol[0])) { n += 1; i += 2; continue; }
                if ((s[i + 1] == simvol[2])) { n += 10; i += 2; continue; }
                if ((s[i + 1] == simvol[4])) { n += 100; i += 2; continue; }
            }
            return n;
        }
        #endregion

        #region 2
        public static Boolean BalanceParentheses(string s)
        {
            Stack<char> x = new Stack<char>();
            for (int i =0; i < s.Length; i++)
            {
                if (s[i] == '(') { x.Push('('); continue; }
                if (s[i] == ')') if (x.Any()) x.Pop(); else return false;
            }
            if (x.Any()) return false; else return true;                                            
        }
        #endregion
    }
}
