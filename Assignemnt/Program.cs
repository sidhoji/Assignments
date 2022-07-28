using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignemnt
{
    class Program
    {
        static void Main(string[] args)
        {   //Question no 1 : write a c# program to print hello and your name in a separate line 
            Console.WriteLine("write a c# program to print hello and your name in a separate line ");
            Console.WriteLine("HELLO" + "\n" + "SIDHOJI");


            //Question no 2 : write a c# program to swap two numbers

            // program using 3 variables
            //Console.WriteLine("write a c# program to swap two numbers");
            //int num1, num2, temp;
            //Console.WriteLine("Enter two numbers num1 and num2:");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //num2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("the two numbers num1 and num2 are : {0} , {1} respectively ", num1, num2);
            //temp = num1;
            //num1 = num2;
            //num2 = temp;
            //Console.WriteLine("the swapped numbers num1 and num2 are : {0} , {1}respectively", num1, num2);

            // swap program using 2 variables
            Console.WriteLine("write a c# program to swap two numbers");
            int numb1, numb2;
            Console.WriteLine("Enter two numbers numb1 and numb2:");
            numb1 = Convert.ToInt32(Console.ReadLine());
            numb2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("the two numbers num1 and num2 are : {0} , {1} ", numb1, numb2);
            numb2 = numb1 + numb2;
            numb1 = numb2 - numb1;
            numb2 = numb2 - numb1;
            Console.WriteLine("the swapped numbers num1 and num2 are : {0} , {1} ", numb1, numb2);


            //Question no 3 : Write a program to print on screen the output of adding , subtracting , multiplying and dividining of 2 numbers entered by the user
            Console.WriteLine("Write a program to print on screen the output of adding , subtracting , multiplying and dividining of 2 numbers entered by the user");
            int no1, no2;
            Console.WriteLine("enter two numbers no1 and no2 : ");
            no1 = Convert.ToInt16(Console.ReadLine());
            no2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("The result of addition of two numbers is  " + Convert.ToString(no1 + no2));
            if (no1 > no2)
                Console.WriteLine("The result of subtracting of two numbers is  " + Convert.ToString(no1 - no2));
            else if (no2 > no1)
                Console.WriteLine("The result of subtracting of two numbers is  " + Convert.ToString(no2 - no1));
            else
                Console.WriteLine("The result of subtracting of two numbers is 0  ");
            Console.WriteLine("The result of multiplication of two numbers is {0}", Convert.ToString(no1 * no2));
            if (no1 > no2)
                Console.WriteLine("The result of division  of two numbers is {0}", Convert.ToString(no1 / no2));
            else
                Console.WriteLine("The result of division  of two numbers is {0}", Convert.ToString(no1 / no2));


            //Question 4 : Write a program that takes  a number from the user and prints its multiplication table 
            Console.WriteLine("Write a program that takes  a number from the user and prints its multiplication table");
            int num, itr;
            Console.WriteLine("enter the number :  ");
            num = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("enter till which multiple you want to print ");
            itr = Convert.ToInt16(Console.ReadLine());
            for (int i = 1; i < itr + 1; i++)
            {
                Console.WriteLine($"{num} * {i} = {num * i }");
            }

            //Question 5 : Write a C# program to that takes a number as input and display it four times in a row (separated by blank spaces), and then four times in the next row, with no separation.
            //Enter a digit: 25
            //Expected Output:
            // 25 25 25 25
            //25252525
            Console.WriteLine("Write a C# program to that takes a number as input and display it four times in a row (separated by blank spaces), and then four times in the next row, with no separation.");
            
            int number;
            Console.WriteLine("enter the number : ");
            number = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine($" {number} {number} {number} {number}");
            Console.WriteLine($" {number}{number}{number}{number}");

            // question no 6 : Write a C# program to create a new string from a given string where the first and last characters will change their positions. 
            Console.WriteLine("Write a C# program to create a new string from a given string where the first and last characters will change their positions. ");
            string str;
            Console.WriteLine("enter a string : ");
            str = Console.ReadLine();
            StringBuilder str1 = new StringBuilder(str);
            char temp1 = str[0];
            str1[0] = str[str.Length -1 ];
            str1[str1.Length - 1] = temp1;
            Console.WriteLine(str1);

            //question no 7 : Write a C# program to check two given integers and return true if one is negative and one is positive.
            Console.WriteLine("Write a C# program to check two given integers and return true if one is negative and one is positive."); 
            int numb11, numb22;
            Console.WriteLine("enter two signed integers:");
            numb11= Convert.ToInt32(Console.ReadLine());
            numb22= Convert.ToInt32(Console.ReadLine());
            if ((numb11 > 0 && numb22 < 0) || (numb11 < 0 && numb22 > 0))
                Console.WriteLine("true");
            else Console.WriteLine("false");


            //question 9 : Write a C# program and compute the sum of the digits of an integer.
            Console.WriteLine("Write a C# program and compute the sum of the digits of an integer.");
            int m, sum = 0, n;
            Console.WriteLine("enter an integer : ");
            n = Convert.ToInt16(Console.ReadLine()); ;
            while (n > 0)
            {
                m = n % 10;
                sum = sum + m;
                n = n / 10;
            }
            Console.WriteLine("sum of digits of integer is {0}", sum);

            //question 13.	Write a C# Sharp program to get the ASCII value of a given character
            Console.WriteLine("Write a C# Sharp program to get the ASCII value of a given character");
            char cha;
            Console.WriteLine("enter a char : ");
            cha = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("The asci code of " + cha + " is : " + (int)cha);


            //question 15.	Write a C# Sharp program to remove all characters which are non-letters from a given string.
            Console.WriteLine("Write a C# Sharp program to remove all characters which are non-letters from a given string.");
            string s;
        Console.WriteLine("Enter a string");
         s=Console.ReadLine();
            for (int i = 0; i < s.Length; i++)
            {

                if (s[i] < 'A' || s[i] > 'Z' && s[i] < 'a' || s[i] > 'z')

                {
                    s = s.Remove(i, 1);
                    i--;
                }
            }

            Console.Write(s);

            //question 12.	Write a C# program to check if a given string is a palindrome or not. 
            Console.WriteLine("Write a C# program to check if a given string is a palindrome or not. ");
            string str3, rev;
            Console.WriteLine("enter a string:");
            str3 = Console.ReadLine();
            char[] ch = str3.ToCharArray();
            Array.Reverse(ch);
            rev = new string(ch);
            if (rev == str3)
                Console.WriteLine("The entered string is a Palindrome!");
            else
                Console.WriteLine("The entered string is not a Palindrome");


            //question 14 Write a C# Sharp program to convert an integer to string and a string to an integer.
            Console.WriteLine("Write a C# Sharp program to convert an integer to string and a string to an integer.");
            string string1,string2;
            int nn,mm;
            Console.WriteLine("Enter a string:");
            string1 = Console.ReadLine();
            Console.WriteLine("Enter any integer:");
            nn = Convert.ToInt32(Console.ReadLine());
            mm = Convert.ToInt32(string1);
            Console.WriteLine($"The data type of {mm} is {mm.GetType()}");
            string2 = Convert.ToString(nn);
            Console.WriteLine($"The data type of {string2} is {string2.GetType()}");

            //question 11. Write a C# program to create a new array of length containing the middle elements of three arrays (each length 3) of integers.
            Console.WriteLine("Write a C# program to create a new array of length containing the middle elements of three arrays (each length 3) of integers.");
            int[][] arr1 = new int[3][];
            int[] result = new int[3];
            Console.WriteLine("enter an 3*3 array of integers : ");


            arr1[0] = new int[3];
            arr1[1] = new int[3];
            arr1[2] = new int[3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arr1[i][j] = Convert.ToInt32(Console.ReadLine());

                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{arr1[i][j]}   ");


                }
                Console.WriteLine();
            }
            for (int i = 0; i < 3; i++)
            {
                result[i] = arr1[i][1];
            }
            Console.WriteLine("The new array of middle elements is :");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(result[i]);
            }
            //question 6: Write a C# program to create a new string from a given string where the first and last characters will change their positions.
            Console.WriteLine("Write a C# program to create a new string from a given string where the first and last characters will change their positions.");
            Console.WriteLine("enter a string");
            String ss = Console.ReadLine(); 
            char[] mmm = ss.ToCharArray();
            char f1, f2;
            f1 = mmm[0];
            f2 = mmm[ss.Length - 1];
            ss = f2 + ss.Substring(1,ss.Length-2) + f1;
            Console.WriteLine(ss);

            // question 8.	Write a C# program to find the longest word in a string.
            Console.WriteLine("Write a C# program to find the longest word in a string.");
            string s1;
            Console.WriteLine("Enter a string : ");
            s1 = Console.ReadLine();
            //char[] arr = new char [] {' ' };            
            string[] s2 = s1.Split(' ' );
            string str_max= null ;
            int maxlength=0;
            for (int i =0; i<s2.Length-1;i++)
            {
                if (s2[i].Length > maxlength)
                {
                    str_max = s2[i];
                    maxlength=s2[i].Length;
                }            
                  

            }
            Console.WriteLine($"the longest word in the string is : {str_max} and its length is {maxlength}");

        }
    }
}
