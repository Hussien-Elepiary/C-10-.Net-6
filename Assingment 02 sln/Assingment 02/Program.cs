using System.ComponentModel;
using System.Diagnostics;

namespace Assingment_02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int ValueTypeByValue = 0;
            int ValueTypeByReference = 0;

            int[] Arr01TypeByValue = { 1, 2, 3 };
            int[] Arr02TypeByReference = { 4, 5, 6 };

            int number;
            bool flag;

            do
            {
                Console.Write($"Enter Question number from number 1 to number 6: ");
                flag = int.TryParse(Console.ReadLine(), out number);
            }
            while (!flag); // if the user inserted a text not a number

            switch (number) {
                
                case 1:
                    Console.WriteLine("Write a program in C# Sharp to find the sum of all elements of the array.");
                    ArrSum();
                    break;
                case 2:
                    Console.WriteLine("Write a program in C# Sharp to count a total number of duplicate elements in an array.");
                    ArrSameNumbersCounter();
                    break;
                case 3:
                    Console.WriteLine("Write a program in C# Sharp to merge two arrays of same size sorted in ascending order.");
                    MergeAndSortArray();
                    break;
                case 4:
                    Console.WriteLine("Write a program in C# Sharp to count the frequency of each element of an array.");
                    CountTheFrequencyOfEachElement();
                    break;
                case 5:
                    Console.WriteLine("Write a program in C# Sharp to find maximum and minimum element in an array.");
                    FindMinAndMaxValue();
                    break;
                case 6:
                    Console.WriteLine("Write a program in C# Sharp to find the second largest element in an array.");
                    FindSecondLargestElement();
                    break;
                default:
                    #region Explain the difference between passing(Value type parameters) by value and by reference then write a suitable c# example
                    Console.WriteLine("Explain the difference between passing(Value type parameters) by value and by reference then write a suitable c# example");
                    PassingValueTypeParameters(ValueTypeByValue, ref ValueTypeByReference);
                    Console.WriteLine($"ValueTypeByValue = {ValueTypeByValue} And ValueTypeByReference = {ValueTypeByReference} ");
                    #endregion

                    #region Explain the difference between passing(Reference type parameters) by value and by reference then write a suitable c# example 01
                    Console.WriteLine();
                    Console.WriteLine("Explain the difference between passing(Reference type parameters) by value and by reference then write a suitable c# example 01");
                    PassingReferenceTypeParametersEx01(Arr01TypeByValue, ref Arr02TypeByReference);
                    Console.WriteLine($"ByValue: {Arr01TypeByValue[0]}||| ByReference : {Arr02TypeByReference[0]} ");
                    #endregion

                    #region Explain the difference between passing(Reference type parameters) by value and by reference then write a suitable c# example 02
                    Console.WriteLine();
                    Console.WriteLine("Explain the difference between passing(Reference type parameters) by value and by reference then write a suitable c# example 02");
                    PassingReferenceTypeParametersEx02(Arr01TypeByValue, ref Arr02TypeByReference);
                    Console.WriteLine($"ByValue: {Arr01TypeByValue[0]}||| ByReference : {Arr02TypeByReference[0]} ");

                    #endregion

                    #region Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
                    Console.WriteLine();
                    Console.WriteLine("Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers");
                    int Fnumber = 5, Snumber = 5, Sub, Sum;
                    CalculateSumAndSub(Fnumber, Snumber, out Sum, out Sub);
                    Console.WriteLine($"Sum : {Sum} And Sub = {Sub}");
                    #endregion
                    break;
            }

        }

        //1. Write a program in C# Sharp to find the sum of all elements of the array. 

        // the following method is to sum the following arr only
        static void ArrSum()
        {
            int[] arrTosum = { 5,5,5,5,5,5,5,5};
            int total = 0;

            foreach (var number in arrTosum)
            {
                total += number;
            };

            Console.WriteLine($"Total of the Arr : {total}");
        }

        //2. Write a program in C# Sharp to count a total number of duplicate elements in an array.

        static void ArrSameNumbersCounter()
        {

            ulong numbers;
            bool flag;

            do
            {
                Console.Write($"Enter the numbers That you want to put in the arr : ");
                flag = ulong.TryParse(Console.ReadLine(), out numbers);
            }
            while (!flag); // if the user inserted a text not a number


            char[] NumbersArr = numbers.ToString().ToCharArray();


            int number;

            do
            {
                Console.Write($"Enter The Number that You Want the Count of Duplicates of : ");
                flag = int.TryParse(Console.ReadLine(), out number);
            }
            while (!flag); // if the user inserted a text not a number

            int Counter = 0;

            foreach (var item in NumbersArr)
            {
                if (number == int.Parse(item.ToString()))
                {
                    Counter += 1;
                }
            }

            Console.WriteLine($"There is {Counter} of number {number}");
        }

        //3. Write a program in C# Sharp to merge two arrays of same size sorted in ascending order.

        static void MergeAndSortArray()
        {
            ulong numbers;
            bool flag;

            do
            {
                Console.Write($"Enter the numbers That you want to put in the arr : ");
                flag = ulong.TryParse(Console.ReadLine(), out numbers);
            }
            while (!flag); // if the user inserted a text not a number

            char[] NumbersArr01 = numbers.ToString().ToCharArray();

            do
            {
                Console.Write($"Enter the numbers That you want to put in the arr : ");
                flag = ulong.TryParse(Console.ReadLine(), out numbers);
            }
            while (!flag); // if the user inserted a text not a number

            char[] NumbersArr02 = numbers.ToString().ToCharArray();

            char[] NumbersArrCompiend;
            if (NumbersArr02.Length > 0 || NumbersArr01.Length >0)
            {
                NumbersArrCompiend = new char[NumbersArr02.Length + NumbersArr01.Length];
                NumbersArr01.CopyTo(NumbersArrCompiend, 0);  
                NumbersArr02.CopyTo(NumbersArrCompiend, NumbersArr01.Length);
                Array.Sort(NumbersArrCompiend);
                Console.WriteLine(NumbersArrCompiend);
            }
        }

        //4. Write a program in C# Sharp to count the frequency of each element of an array.

        static void CountTheFrequencyOfEachElement()
        {
            //Initialize array   
            int[] arr = new int[] { 1, 2, 8, 3, 2, 2, 2, 5, 1 };
            //Array fr will store frequencies of element  
            int[] fr = new int[arr.Length];// this array is to count the freq number for each element
            int visited = -1; // making it -1 is for adding it up for next visit 

            for (int i = 0; i < arr.Length; i++)
            {
                int count = 1;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        //To avoid counting same element again  
                        fr[j] = visited;
                    }
                }
                if (fr[i] != visited)
                    fr[i] = count;
            }

            //Displays the frequency of each element present in array  
            Console.WriteLine(" Element | Frequency");
            Console.WriteLine("---------------------");
            for (int i = 0; i < fr.Length; i++)
            {
                if (fr[i] != visited)
                    Console.WriteLine($" {arr[i]} |  {fr[i]}");
            }
        }

        //5. Write a program in C# Sharp to find maximum and minimum element in an array
        static void FindMinAndMaxValue()
        {
            ulong numbers;
            bool flag;

            do
            {
                Console.Write($"Enter the numbers That you want to put in the arr : ");
                flag = ulong.TryParse(Console.ReadLine(), out numbers);
            }
            while (!flag); // if the user inserted a text not a number


            char[] NumbersArr = numbers.ToString().ToCharArray();

            Console.WriteLine($"Minimum Value in {NumbersArr.Min()} And Maximum Value is {NumbersArr.Max()}");
        }

        //6. Write a program in C# Sharp to find the second largest element in an array.

        static void FindSecondLargestElement() 
        {
            ulong numbers;
            bool flag;

            do
            {
                Console.Write($"Enter the numbers That you want to put in the arr : ");
                flag = ulong.TryParse(Console.ReadLine(), out numbers);
            }
            while (!flag); // if the user inserted a text not a number

            char[] NumbersArr = numbers.ToString().ToCharArray();

            Array.Sort(NumbersArr);
            Console.WriteLine($"The Second Largest Element in the inserted arr is : {NumbersArr[NumbersArr.Length-2]}");
        }

        //Functions

        //Explain the difference between passing(Value type parameters) by value and by reference then write a suitable c# example.

        // in pasing value type pram 
        // by value it just copys the value in param1 and pass it to param2 in the stack 
        // by refrance it takes the param it self with it`s value and change it

        

        static void PassingValueTypeParameters(int x , ref int y) 
        { 
            x = 5; 
            y = 5;
            Console.WriteLine($"x = { x } And y = { y }");
        }



        //Explain the difference between passing(Reference type parameters) by value and by reference then write a suitable c# example.

        // in the following example the value type passing takes just the addres for the array and then make a new array in the function so that changes the
        // address in the method it self after and create a new opject in heap
        // but in the ref type pass it bass the opject with its address so when you make a new array
        // it changes the address for the sent opject making the opject unreachable  
        static void PassingReferenceTypeParametersEx01(int[] x, ref int[] y)
        {
            x = new int[3] { 10, 11, 12 };
            y = new int[3] { 20, 21, 22 };
        }


        // in the following example i have the same address for both ref and value so if i make any changes i make it in the same opject 

        static void PassingReferenceTypeParametersEx02(int[] x, ref int[] y)
        {
            x[0] = 100;
            y[0] = 200;
        }

        //Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers

        static void CalculateSumAndSub(int x, int y , out int a, out int b)
        {
            a = x + y;
            b = x - y;
        }

    }
}