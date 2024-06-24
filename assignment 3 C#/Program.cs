using System;

namespace assignment3CSharp

{
    class program
    {
        static void Main(string[] args)
        {
            #region Q 1
            //Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
            Console.WriteLine("Enter a number:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            if (number1 % 3 == 0 && number1 % 4 == 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            #endregion

            #region Q 2 
            //Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            Console.WriteLine("Enter an integer:");
            int number2 = Convert.ToInt32(Console.ReadLine());
            if (number2 < 0)
            {
                Console.WriteLine("Negative");
            }
            else
            {
                Console.WriteLine("Positive");
            }
            #endregion

            #region Q 3
            // Write a program that takes 3 integers from the user then prints the max
            // element and the min element.
            Console.WriteLine("Enter three integers:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            int max = Math.Max(num1, Math.Max(num2, num3)); // max function take 2 parametre only !
            int min = Math.Min(num1, Math.Min(num2, num3)); // min function take 2 parametre only !
            Console.WriteLine($"Max element = {max}");
            Console.WriteLine($"Min element = {min}");
            #endregion

            #region Q 4
            // Write a program that allows the user to insert an integer number then
            // check If a number is even or odd.
            Console.WriteLine("Enter an integer:");
            int number4 = Convert.ToInt32(Console.ReadLine());
            if (number4 % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
            #endregion

            #region Q 5
            // Write a program that takes character from the user then if it is a
            // vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant)
            Console.WriteLine("Enter a character:");
            char character = Convert.ToChar(Console.ReadLine().ToLower());
            if ("aeiou".IndexOf(character) >= 0)
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("Consonant");
            }
            #endregion

            #region Q 6
            // Write a program that allows the user to insert an integer then print
            // all numbers between 1 to that number.
            Console.WriteLine("Enter an integer:");
            int number6 = Convert.ToInt32(Console.ReadLine()); 
            for (int i = 1; i <= number6; i++)                  // For loop لسه مخدنهاش ! 
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            #endregion

            #region Q 7
            // Write a program that allows the user to insert an integer then
            // print a multiplication table up to 12.
            Console.WriteLine("Enter an integer:");
            int number7 = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 12; i++)
            {
                Console.Write(number7 * i + " ");
            }
            Console.WriteLine();
            #endregion

            #region Q 8
            // Write a program that allows to user to insert number then print all
            // even numbers between 1 to this number.
            Console.WriteLine("Enter an integer:");
            int number8 = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number8; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
            #endregion

            #region Q 9 
            // Write a program that takes two integers then prints the power
            Console.WriteLine("Enter base and exponent:");
            int baseNumber = Convert.ToInt32(Console.ReadLine());
            int exponent = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math.Pow(baseNumber, exponent));
            #endregion

            #region Q 10 
            // Write a program to enter marks of five subjects and calculate total,
            // average and percentage.
            Console.WriteLine("Enter marks of five subjects:");
            // array of five numbers 
            int[] marks = new int[5]; 
            int total = 0;
            // i = 0 cause the indesx starts from 0 
            for (int i = 0; i < 5; i++)                                 
            {
                // start from 0 to 4 to input five numbers 
                marks[i] = Convert.ToInt32(Console.ReadLine());         
                total += marks[i];
            }
            double average = total / 5.0;
            double percentage = (total / 500.0) * 100;
            Console.WriteLine($"Total marks = {total}");
            Console.WriteLine($"Average marks = {average}");
            Console.WriteLine($"Percentage = {percentage}");
            #endregion

            #region Q 11
            // Write a program to input the month number and print the number of days
            // in that month.
            Console.WriteLine("Enter month number:");
            int month = Convert.ToInt32(Console.ReadLine());
            int days = DateTime.DaysInMonth(2024, month); 
            Console.WriteLine($"Days in month: {days}");
            #endregion

            #region Q 17
            // Create a program that asks the user to input three points (x1, y1),
            // (x2, y2), and (x3, y3), and determines whether these points lie on a
            // single straight line
            Console.WriteLine("Enter coordinates of three points:");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            double x3 = Convert.ToDouble(Console.ReadLine());
            double y3 = Convert.ToDouble(Console.ReadLine());
            double slope1 = (y2 - y1) / (x2 - x1);
            double slope2 = (y3 - y2) / (x3 - x2);
            if (slope1 == slope2)
            {
                Console.WriteLine("Points lie on a single straight line");
            }
            else
            {
                Console.WriteLine("Points do not lie on a single straight line");
            }
            #endregion

            #region Q 18
            // Within a company, the efficiency of workers is evaluated based on the
            // duration required to complete a specific task. A worker's efficiency level
            // is determined as follows:
            // - If the worker completes the job within 2 to 3 hours, they are considered
            // highly efficient.
            // - If the worker takes 3 to 4 hours, they are instructed to increase their
            // speed.
            // - If the worker takes 4 to 5 hours, they are provided with training to
            // enhance their speed.
            // - If the worker takes more than 5 hours, they are required to leave the
            // company.
            Console.WriteLine("Enter the hours taken to complete the task:");
            double hours = Convert.ToDouble(Console.ReadLine());
            if (hours >= 2 && hours <= 3)
            {
                Console.WriteLine("Highly efficient");
            }
            else if (hours > 3 && hours <= 4)
            {
                Console.WriteLine("Increase your speed");
            }
            else if (hours > 4 && hours <= 5)
            {
                Console.WriteLine("Training required");
            }
            else if (hours > 5)
            {
                Console.WriteLine("Leave the company");
            }
            #endregion

            #region Q 21
            // Write C# program that Assigning one value type
            // variable to another and modifying the value of one
            // variable and mention what will happen.
            int val1 = 10;
            int val2 = val1;
            val2 = 20;
            Console.WriteLine($"val1: {val1}, val2: {val2}");
            // Output: val1 will remain 10, val2 will be 20 because value types are copied by value.
            #endregion

            #region Q 22
            // Write C# program that Assigning one reference type
            // variable to another and modifying the object through
            // one variable and mention what will happen.
            int[] array1 = { 1, 2, 3 };
            int[] array2 = array1;
            array2[0] = 10;
            Console.WriteLine($"array1[0]: {array1[0]}, array2[0]: {array2[0]}");
            // the last code in lines is array[0] = 10 ,, then it will be 10 in output
            // Output: array1[0] and array2[0] both will be 10 because reference types are copied by reference.
            #endregion

            #region Q 23
            // Which of the following statements is correct about
            // the C#.NET code snippet given below?
            // int d; 
            // d = Convert.ToInt32(!(30 < 20));
            int d;
            d = Convert.ToInt32(!(30 < 20));
            Console.WriteLine(d);
            // Output: 1 (since !(30 < 20) is TRUE and Convert.ToInt32(true) is 1)
            #endregion

            #region Q 24
            // Which of the following is the correct output for
            // the C# code given below?
            // Console.WriteLine(13 / 2 + " " + 13 % 2);
            Console.WriteLine(13 / 2 + " " + 13 % 2);
            // 13 / 2 = 6.5 => 6 in console ,, 13 % 2 => 12 % 2 = 0 + (1) باقي القسمة  
            // Output: 6 1
            #endregion

            #region Q 25 
            // What will be the output of the C# code given below?
            // int num = 1, z = 5;
            // if (!(num <= 0))
            //     Console.WriteLine(++num + z++ + " " + ++z);
            // else
            //     Console.WriteLine(--num + z-- + " " + --z);
            int num = 1, z = 5;
            if (!(num <= 0))
            {
                Console.WriteLine(++num + z++ + " " + ++z);
            }
            else
            {
                Console.WriteLine(--num + z-- + " " + --z);
            }
            // Output: 7 7
            #endregion

















        }
    }
}