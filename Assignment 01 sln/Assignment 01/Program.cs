using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Assignment_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //1 - Write a program that allows the user to enter a number then print it.
            //Example
            //Input: 5
            //Output: 5

            ////the following code is to display any number more or less or ==  0 
            //int number;
            //bool flag;
            //do
            //{
            //    Console.Write("Enter A Number : ");
            //    flag = int.TryParse(Console.ReadLine(), out number);
            //}
            //while (!flag); // if the user inserted a text not a number
            //Console.WriteLine($"You Have Entered Number {number}");
            #endregion

            #region Q2
            //2 - Write a program that takes a number from the user then print yes if that
            //number can be divided by 3 and 4 otherwise print no.
            //Example(1)
            //Input: 12
            //Output: Yes
            //Example(2)
            //Input: 9
            //Output: No

            //int number;
            //bool flag;
            //do
            //{
            //    Console.Write("Enter A Number : ");
            //    flag = int.TryParse(Console.ReadLine(), out number);
            //}
            //while (!flag); // if the user inserted a text not a number
            //if ((number % 4) == 0 && (number % 3) == 0)
            //    Console.WriteLine("YES");
            //else
            //    Console.WriteLine("NO");

            #endregion

            #region Q3
            //3 - Write a program that allows the user to insert 2 integers then print the
            //max.
            //Example(1)
            //Input: 3 5
            //Output: 5
            //Example(2)
            //Input: 10 7
            //Output: 10

            //int number1,number2;
            //bool flag;
            //do
            //{
            //    Console.Write("Enter A First Number : ");
            //    flag = int.TryParse(Console.ReadLine(), out number1);
            //}
            //while (!flag); // if the user inserted a text not a number
            //do
            //{
            //    Console.Write("Enter A Second Number : ");
            //    flag = int.TryParse(Console.ReadLine(), out number2);
            //}
            //while (!flag); // if the user inserted a text not a number
            //// First Way
            //if (number1 > number2)
            //{
            //    Console.WriteLine(number1);
            //}
            //else if (number1 < number2)
            //{
            //    Console.WriteLine(number2);
            //}
            //else
            //{
            //    Console.WriteLine("they are equal");
            //}
            //Console.WriteLine("===========================");
            ////other way 
            //Console.WriteLine(number1 > number2 ? number1 : number2 > number1 ? number2 : "they are equal");
            #endregion

            #region Q4
            //4 - Write a program that allows the user to insert an integer then print
            //negative if it is negative number otherwise print positive.
            //Example(1)
            //Input: -5
            //Output: negative
            //Example(2)
            //Input: 10
            //Output: positive

            //int number;
            //bool flag;
            //do
            //{
            //    Console.Write("Enter A Number : ");
            //    flag = int.TryParse(Console.ReadLine(), out number);
            //}
            //while (!flag); // if the user inserted a text not a number

            //if (number > 0)
            //{
            //    Console.WriteLine("positive");
            //}
            //else
            //{
            //    Console.WriteLine("negative");
            //}

            //Console.WriteLine("====================");
            //Console.WriteLine(number>0? "positive": "negative");

            #endregion

            #region Q5
            //5 - Write a program that takes 3 integers from the user then prints the max
            //element and the min element.
            //Example(1)
            //Input: 7,8,5
            //Output:
            //            max element = 8
            //min element = 5
            //Example(2)
            //Input: 3 6 9
            //Outputs:
            //            Max element = 9
            //Min element = 3

            //int number1,number2,number3;
            //bool flag;
            //do
            //{
            //    Console.Write("Enter A First Number : ");
            //    flag = int.TryParse(Console.ReadLine(), out number1);
            //}
            //while (!flag); // if the user inserted a text not a number
            //do
            //{
            //    Console.Write("Enter A Second Number : ");
            //    flag = int.TryParse(Console.ReadLine(), out number2);
            //}
            //while (!flag); // if the user inserted a text not a number
            //do
            //{
            //    Console.Write("Enter A Third Number : ");
            //    flag = int.TryParse(Console.ReadLine(), out number3);
            //}
            //while (!flag); // if the user inserted a text not a number

            //int min;

            //if (number1 > number2 && number1 > number3)
            //{
            //    min = number2 > number3 ? number3 : number2;
            //    Console.WriteLine($"Max number : {number1} , Min Number {min}");
            //}
            //else if (number2 > number1 && number2 > number3)
            //{
            //    min = number1 > number3 ? number3 : number1;
            //    Console.WriteLine($"Max number : {number2} , Min Number {min}");
            //}
            //else if (number3 > number1 && number3 > number2)
            //{
            //    min = number1 > number2 ? number2 : number1;
            //    Console.WriteLine($"Max number : {number3} , Min Number {min}");
            //}

            #endregion

            #region Q6
            //6 - Write a program that allows the user to insert an integer number then
            //check If a number is even or odd.

            //int number;
            //bool flag;
            //do
            //{
            //    Console.Write("Enter A Number : ");
            //    flag = int.TryParse(Console.ReadLine(), out number);
            //}
            //while (!flag); // if the user inserted a text not a number
            //string evenOrOddFlag = number % 2 == 0 ? "Even" : "ODD";
            //Console.WriteLine($"Your Number is {evenOrOddFlag}");
            #endregion

            #region Q7
            //7 - Write a program that takes character from the user then if it is a vowel
            //chars(a, e, I, o, u) then print(vowel) otherwise print(consonant).
            //Example(1)
            //Input: O
            //Output: vowel
            //Example(2)
            //Input: b
            //Output: Consonant

            //char character;
            //bool flag;
            //do
            //{
            //    Console.Write("Enter A Character : ");
            //    flag = char.TryParse(Console.ReadLine(), out character);

            //}
            //while (!flag); // if the user inserted a text not a number

            //Console.WriteLine("Switch");
            //Console.WriteLine();
            //switch (character.ToString().ToLower())
            //{
            //    case "a":
            //    case "e":
            //    case "i":   
            //    case "o":
            //    case "u":   
            //        Console.WriteLine("Vowel");
            //        break;
            //    default:
            //        Console.WriteLine("Consonant");
            //        break;
            //}
            //Console.WriteLine("IF");
            //Console.WriteLine();
            //if (character.ToString().ToLower() == "a" || character.ToString().ToLower() == "e" || character.ToString().ToLower() == "o" || character.ToString().ToLower() == "i" || character.ToString().ToLower() == "u")
            //{
            //    Console.WriteLine("Vowel");
            //}
            //else
            //{
            //    Console.WriteLine("Consonant");
            //}
            #endregion

            #region Q8
            //8 - Write a program that allows the user to insert an integer then print all
            //            numbers between 1 to that number.
            //Example
            //Input: 5
            //Output: 1, 2, 3, 4, 5

            //int number;
            //bool flag;
            //do
            //{
            //    Console.Write("Enter A Number : ");
            //    flag = int.TryParse(Console.ReadLine(), out number);
            //}
            //while (!flag); // if the user inserted a text not a number

            //for (int i = 1; i <= number; i++)
            //{
            //    Console.Write($" {i} ,");
            //}

            #endregion

            #region Q9
            //9 - Write a program that allows the user to insert an integer then
            //            print a multiplication table up to 12.
            //Example
            //Input: 5
            //Outputs: 5 10 15 20 25 30 35 40 45 50 55 60

            //int number;
            //bool flag;
            //do
            //{
            //    Console.Write("Enter A Number : ");
            //    flag = int.TryParse(Console.ReadLine(), out number);
            //}
            //while (!flag); // if the user inserted a text not a number

            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.Write($" {number * i} ");
            //}

            #endregion

            #region Q10
            //10 - Write a program that allows to user to insert number then print all even
            //numbers between 1 to this number
            //Example:
            //Input: 15
            //Output: 2 4 6 8 10 12 14

            //int number;
            //bool flag;
            //do
            //{
            //    Console.Write("Enter A Number : ");
            //    flag = int.TryParse(Console.ReadLine(), out number);
            //}
            //while (!flag); // if the user inserted a text not a number

            //for (int i = 1; i <= number; i++)
            //{
            //    Console.Write(i%2==0?i:" ");
            //}

            #endregion

            #region Q11

            //11 - Write a program that takes two integers then prints the power.
            //Example:
            //        Input: 4 3
            //Output: 64
            //Hint: how to calculate 4 ^ 3 = 4 * 4 * 4 = 64

            //int number,power;
            //bool flag;
            //do
            //{
            //    Console.Write("Enter Base Number : ");
            //    flag = int.TryParse(Console.ReadLine(), out number);
            //}
            //while (!flag); // if the user inserted a text not a number
            //do
            //{
            //    Console.Write("Enter Power Number : ");
            //    flag = int.TryParse(Console.ReadLine(), out power);
            //}
            //while (!flag); // if the user inserted a text not a number

            //int result = 1; 
            //for (int i = 0; i < power; i++)
            //{
            //    result *= number;
            //}
            //Console.WriteLine($"The Power Of {number} ^ {power} = {result}");

            #endregion

            #region Q12
            //12 - Write a program to enter marks of five subjects and calculate total,
            //average and percentage.
            //Example
            //Input: -Enter Marks of five subjects: 95 76 58 90 89
            //Output: Total marks = 408
            //Average Marks = 81
            //Percentage = 81

            //int[] marks = new int[5];
            //bool flag;
            //Console.WriteLine("Marks Must be less than or = 100");
            //for (int i = 0; i < marks.Length;)
            //{
            //    Console.Write($"Enter Mark For Supject number {i + 1} : ");
            //    flag = int.TryParse(Console.ReadLine(), out marks[i]);
            //    if (flag && marks[i] <= 100)
            //        i++; // if the user inserted a text not a number
            //}
            //Console.Clear();
            //int total = 0;
            //double avg, Percent;

            //for (int i = 0; i < marks.Length; i++)
            //{
            //    total += marks[i];
            //}
            //avg = total / marks.Length;
            //Percent = (double)total / 500; // IDK what happen in the following Code this is how i get the Avg every time 
            //Console.WriteLine($"Total of Marks is : {total}");
            //Console.WriteLine($"Average of Marks is : {avg}");
            //Console.WriteLine($"Percentage of Marks is : {Percent.ToString("0.0%")}");


            #endregion

            #region Q13
            //13 - Write a program to input the month number and print the number of days in
            //that month.
            //Example
            //Input: Month Number: 1
            //Output: Days in Month: 31

            //int number;
            //bool flag;
            //do
            //{
            //    Console.Write("Enter A Month Number : ");
            //    flag = int.TryParse(Console.ReadLine(), out number);
            //}
            //while (!flag || 0 >= number || number > 12 ); // if the user inserted a text not a number


            //Console.WriteLine($"Days in Month: {DateTime.DaysInMonth(int.Parse(DateTime.Now.ToString("yyyy")),number)} ");

            #endregion

            #region Q14
            //14 - Write a program to input marks of five subjects Physics, Chemistry,
            //Biology, Mathematics and Computer, And Calculate percentage and grade.
            //Hint:
            //Percentage & gt;= 90 %: Grad A
            //Percentage & gt;= 80 %: Grad B
            //Percentage & gt;= 70 %: Grad C
            //Percentage & gt;= 60 %: Grad D
            //Percentage & gt;= 40 %: Grad E
            //Percentage & lt; 40 %: Grad F

            //int[] marks = new int[5];
            //string[] supject = new string[5] { "Physics", "Chemistry", "Biology", "Mathematics", "Computer" };
            //bool flag;
            //Console.WriteLine("Marks Must be less than or = 100");
            //for (int i = 0; i < marks.Length;)
            //{
            //    Console.Write($"Enter Mark For Supject {supject[i]} : ");
            //    flag = int.TryParse(Console.ReadLine(), out marks[i]);
            //    if (flag && marks[i] <= 100)
            //        i++; // if the user inserted a text not a number
            //}

            //int total = marks.Sum();
            //double percent = (double)total / 500;//500 is the max value for the 5 supject 

            //switch (percent)
            //{
            //    case >= 0.9:
            //        Console.WriteLine($"Your Grade is A , Pecentage {percent.ToString("0%")} ");
            //        break;
            //    case >= 0.8:
            //        Console.WriteLine($"Your Grade is B , Pecentage {percent.ToString("0%")} ");
            //        break;
            //    case >= 0.7:
            //        Console.WriteLine($"Your Grade is C , Pecentage {percent.ToString("0%")} ");
            //        break;
            //    case >= 0.6:
            //        Console.WriteLine($"Your Grade is D , Pecentage {percent.ToString("0%")} ");
            //        break;
            //    case > 0.4:
            //        Console.WriteLine($"Your Grade is E , Pecentage {percent.ToString("0%")} ");
            //        break;
            //    default:
            //        Console.WriteLine($"Your Grade is F , Pecentage {percent.ToString("0%")} ");
            //        break;
            //}

            #endregion

            #region Q15
            //15 - Write a program to check whether a number is positive or negative or
            //zero.

            //int number;
            //bool flag;
            //do
            //{

            //    Console.Write($"Enter A Number Between ({int.MaxValue} AND {int.MinValue}) : ");
            //    flag = int.TryParse(Console.ReadLine(), out number);
            //}
            //while (!flag); // if the user inserted a text not a number

            //switch (number)
            //{
            //    case > 0: 
            //        Console.WriteLine("positive");
            //        break;
            //    case < 0:
            //        Console.WriteLine("negative");
            //        break;
            //    default:
            //        Console.WriteLine("Zero");
            //        break;
            //}

            #endregion

            #region Q16
            //16 - Write a program to create a Simple Calculator.

            //int number1,number2;
            //char equation;
            //bool flag;
            //do
            //{
            //    Console.Write("Enter A First Number : ");
            //    flag = int.TryParse(Console.ReadLine(), out number1);
            //}
            //while (!flag); // if the user inserted a text not a number
            //do
            //{
            //    Console.Write("Enter the equation ( + , - , / , * ) : ");
            //    char.TryParse(Console.ReadLine(), out equation);

            //    if (equation == '+' || equation == '-' || equation == '*' || equation == '/') 
            //        flag = true;
            //    else
            //        flag = false;
            //}
            //while (!flag); // if the user inserted a text not a number
            //do
            //{
            //    Console.Write("Enter A Second Number : ");
            //    flag = int.TryParse(Console.ReadLine(), out number2);
            //}
            //while (!flag); // if the user inserted a text not a number

            //switch (equation)
            //{
            //    case '+':
            //        Console.WriteLine($"{number1} {equation} {number2} = {number1 + number2}");
            //        break;
            //    case '-':
            //        Console.WriteLine($"{number1} {equation} {number2} = {number1 - number2}");
            //        break;
            //    case'*':
            //        Console.WriteLine($"{number1} {equation} {number2} = {number1 * number2}");
            //        break;
            //    case '/':
            //        Console.WriteLine($"{number1} {equation} {number2} = {number1 / number2}");
            //        break;
            //}

            #endregion

            #region Q17
            //17 - Write a program to allow the user to enter a string and print the REVERSE
            //of it.

            //Console.Write("Enter a Sentance to play : ");
            //string sentance = Console.ReadLine();
            //char[] charArray = sentance.ToCharArray();
            //Array.Reverse(charArray);
            //Console.WriteLine(new string(charArray));

            #endregion

            #region Q18
            //18 - Write a program to allow the user to enter int and print the REVERSED of
            //it.


            int number;
            bool flag;

            do
            {
                Console.Write("Enter a number to play : ");
                flag = int.TryParse(Console.ReadLine(), out number);
            }
            while (!flag); // if the user inserted a text not a number


            char[] charArray = number.ToString().ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine(charArray);

            #endregion

            #region Q19
            //19.Consider an Array of Integer values with size N, having values as
            //in this Example
            //7 0 0 0 0 5 6 7 5 0 7 5 3
            //write a program find the longest distance between Two equal cells.In this
            //example.The distance is measured by the number Of cells- for example, the
            //distance between the first and the fourth cell is 2(cell 2 and cell 3).
            //In the example above, the longest distance is between the first 7 and the
            //10th 7, with a distance of 8 cells, i.e.the number of cells between the 1st
            //And the 10th 7s.
            //Note:
            //-Array values will be taken from the user
            //-If you have input like 1111111 then the distance is the number of
            //Cells between the first and the last cell.

            //ulong number;
            //bool flag;

            //do
            //{
            //    Console.Write("Enter a number to play : ");
            //    flag = ulong.TryParse(Console.ReadLine(), out number);
            //}
            //while (!flag); // if the user inserted a text not a number


            //char[] charArray = number.ToString().ToCharArray();
            //char[] revCharArray = number.ToString().ToCharArray();
            //char sameValue = '0';

            //int number1 = 0 , number2 = 0, max = 0;

            //Array.Reverse(revCharArray);

            //for (int i = 0; i < charArray.Length; i++)
            //{
            //    for (int j = 0; j < revCharArray.Length; j++)
            //    {
            //        if (charArray[i] == revCharArray[j])
            //            number2 = j;
            //        number1 = i;

            //        if (number2-number1 > max)
            //        {
            //            max = number2 - number1;
            //            sameValue = charArray[number1];
            //        }
            //    }

            //}
            //Console.WriteLine($"Value is {sameValue}, distance = {max}");



            #endregion

            #region Q20
            //20.Given a list of space separated words, reverse the order of the words.

            //Input: this is a test  Output: test a is this
            //Input: all your base   Output: base your all
            //Input: Word            Output: Word
            //Note :
            //Check the Split Function(Member in String Class) Output will be a Single
            //Console.WriteLine Statement


            Console.Write("Enter a Sentance to play : ");
            string sentance = Console.ReadLine();
            string[] sentanceArr = sentance.Split(" ");
            Array.Reverse(sentanceArr);

            string revSentance = string.Join(" ", sentanceArr);

            Console.WriteLine(revSentance);

            #endregion

        }
    }
}