using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace StringPrograms
{
    
    internal class Program
    {
        void reverseStringWords()
        {
            String str = "welcome to pune";
           String[] s= str.Split();
            for(int i = s.Length - 1; i >= 0; i--)
            {
                Console.Write(s[i]+" ");
            }
        }
        void reverseWords(String word)
        {
            for(int i = word.Length - 1;i >= 0; i--)
            {
                Console.Write(word[i]);
            }
        }
        void reverse_each_word()
        {
            String str = "welcome to pune";
            String word = "";
            for(int i=0; i < str.Length; i++)
            {
                if (str[i] !=' ')
                {
                    word += str[i];
                }
                else
                {
                    reverseWords(word);
                    word = "";
                    Console.Write(" ");
                }
            }
            reverseWords(word);
        }

        void reverse_string()
        {
            String str = "welcome to pune";
            for(int i =(str.Length-1); i >= 0; i--)
            {
                Console.Write(str[i]);
            }
        }

        void reverseStringWordWithoutSplit()
        {
            String str = "welcome to pune";
            String word = "";
            String lastString = "";
            for(int i =0;i < str.Length; i++)
            {
                if (str[i] !=' ')
                {
                    word= word + str[i];
                }
                else
                {
                    lastString = word+" " + lastString;
                    word = "";
                }
            }
            Console.Write(word+" "+lastString);
        }
        void removeSpaceFromString()
        {
            String str = "welcome to pune";
            for(int i= 0; i < str.Length; i++)
            {
                if (str[i]!=' ')
                {
                    Console.Write(str[i]);
                }
            }
        }
        void each_Word_new_line()
        {
            String str = "welcome to pune";
            String Msg = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != (' '))
                {
                    Msg = Msg + str[i];
                }
                else
                {
                    Console.WriteLine(Msg);
                    Msg = "";

                }
            }
            Console.WriteLine(Msg);
        }
        void inputStringIsPalidrome()
        {
            String input;
            Console.Write("enter String:");
            input = Console.ReadLine();
            String reverse = "";
            for(int i=input.Length-1; i >=0; i--)
            {
                reverse= reverse + input[i];
            }
            if(reverse == input)
            {
                Console.WriteLine("string is palidrome");
            }
            else { Console.WriteLine("string is not palidrome"); }
        }

        void UniqueChar()
        {
            String input;
            Console.Write("enter String:");
            input = Console.ReadLine();
            String unique = "";
            for(int i = 0 ; i < input.Length ; i++)
            {
                int cnt = 0;
                for(int j = 0; j < unique.Length; j++)
                {
                    if (unique[j] == input[i])
                    {
                        cnt++;
                        break;
                    }
                }
                if(cnt == 0)
                {
                    unique = unique + input[i];
                }
            }
            Console.WriteLine(unique);

        }
        void countrepe()
        {
            String input;
            Console.Write("enter String:");
            input = Console.ReadLine();
            String unique = "";
            for (int i = 0; i < input.Length; i++)
            {
                int cnt = 0;
                for (int j = 0; j < unique.Length; j++)
                {
                    if (unique[j] == input[i])
                    {
                        cnt++;
                        break;
                    }
                }
                if (cnt == 0)
                {
                    unique = unique + input[i];
                }
            }
           for(int i =0 ; i < unique.Length; i++)
            {
                int cnt = 0;
                for (int j = 0; j < input.Length; j++)
                {
                    if (unique[i] == input[j])
                    {
                        cnt++;
                    }
                }
                Console.WriteLine(unique[i]+" "+cnt);

            }
        }


        void isWordPresentInArray()
        {
            String[] str = new String[] { "pune", "solapur", "mumbai", "kolkatta" };
            String input_word;
            int cnt;
            Console.WriteLine("enter city name");
            input_word=Console.ReadLine();
            cnt = 0;
            foreach (String i in str) {
                if(i.Equals(input_word))
                {
                    Console.WriteLine("Pune contains in array");
                    cnt++;
                }
            }
            if (cnt == 0)
            {
                Console.WriteLine(input_word + " not containes in array");
            }

        }
        void reverseStringUsingForeach()
        {
            String input_string, re_string = "";
            String[] arr = new string[10];
            Console.WriteLine("enter string");
            input_string=Console.ReadLine();
            
            for(int i=0 ; i < input_string.Length; i++)
            {
                arr[i] = Convert.ToString(input_string[i]);
            }
            foreach(String i in arr)
            {
                re_string = i + re_string;
            }
            Console.WriteLine(re_string);
        }

        void isSubstring()
        {
            String str, sub_str, new_sub_str = "";
            int j = 0;

            Console.WriteLine("enter string");
            str = Console.ReadLine();
            Console.WriteLine("enter second word");
            sub_str = Console.ReadLine();
            
            for (int i = 0; i < str.Length; i++)
            {
                    if (str[i] == sub_str[j])
                    {
                        new_sub_str += str[i];
                        j++;
                        if (sub_str.Equals(new_sub_str))
                        {
                            Console.WriteLine(sub_str + " is substring of " + str);
                            break;
                        }
                        
                    }
                    else
                    {
                        if (sub_str.Equals(new_sub_str))
                        {
                            Console.WriteLine(sub_str + "  is substring of " + str);
                            break;
                        }
                        else
                        {
                            j = 0;
                        }
                    }
               
            }
            if (!sub_str.Equals(new_sub_str))
            {
                Console.WriteLine(sub_str + "  is not substring of " + str);

            }


        }
        static void Main(string[] args)
        {
            Program p = new Program();
            // p.each_Word_new_line();
            //p.reverseStringWords();
            //p.reverse_each_word();
            //p.reverse_string();
            // p.removeSpaceFromString();
            // p.reverseStringWordWithoutSplit();
            //p.inputStringIsPalidrome();
            //p.UniqueChar();
            // p.countrepe();
            //p.isWordPresentInArray();
           // p.reverseStringUsingForeach();
           p.isSubstring();
            Console.ReadLine();
        }
    }
}
