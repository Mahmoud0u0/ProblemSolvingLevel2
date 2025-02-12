﻿using System;




namespace ProblemSolveng_Level_2_From_2_to_10
{
    internal class Program
    {
        static int ReadPositiveNumber(string Message)
        {
            int num = 0;
            string input = "";

            do
            {
                Console.Write(Message);
                input = Console.ReadLine();

            } while ((!int.TryParse(input, out num)) || num <= 0);

            return num;
        }


        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////// Problem Solving From 1 to 10 //////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        /// Problem 2
        /// //////////////////////// Prime Numbers From 1 to N/////////////////

        enum enPrimNotPrime { Prime = 1, NotPrime = 2 };
        
        static enPrimNotPrime ChickPrime(int Number)
        {
            int M = 0;
            double value = Number / 2;
            M = Convert.ToInt32(Math.Round(value));

            for (int Counter = 2; Counter <= M; Counter++)
            {
                if(Number %  Counter == 0)
                {
                    return enPrimNotPrime.NotPrime;
                    Console.WriteLine();
                }
            }

            return enPrimNotPrime.Prime;
        }

        static void PrintPeimeNumbersFrom1ToN(int Number)
        {
            for(int i = 1; i <= Number; i++){

                if (ChickPrime(i) == enPrimNotPrime.Prime)
                {
                    Console.WriteLine(i);
                }
            }
        }



        /// Problem 3, 4
        /// //////////////////////// if the Number is a Perfect Number or Not /////////////////


        static bool isPerfectNumber(int Number)
        {
            int sum = 0;

            for(int i = 1; i < Number; i++)
            {
                if (Number % i == 0)
                {
                    sum += i;
                }
            }

            return Number == sum;
        }

        static void PrintPerfectResult(int Number)
        {
            if (isPerfectNumber(Number))
            {
                Console.WriteLine($"The Number {Number} is a Perfect Number ");
            }
            else
            {
                Console.WriteLine($"The Number {Number} is Not a Perfect Number ");
            }
        }

        static void PrintPerfectNumberFrom1ToN(int Number)
        {
            for (int i = 1; i <= Number; i++)
            {
                if (isPerfectNumber(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        /// Problem 5
        /// //////////////////////// Reversed Number /////////////////

        static void PrintReversedNumber(int number)
        {
            int reversNum = 0;

            while (number > 0)
            {
                reversNum = number % 10;
                number = number / 10;
                Console.WriteLine(reversNum);
            }
        }

        /// Problem 5
        //////////////////////////// Reversed Number ///////////////// 

        static void PrintTheDigitsOfNumber(int number)
        {
            int sum = 0;

            while(number > 0)
            {
                sum += number % 10;
                number = number / 10;
            }
            Console.WriteLine(sum);
        }

        /// Problem 6, 7
        /// //////////////////////// Read Number And Printed Reversed /////////////////

        static void ReadNumberAndPrintedReversedUsingString(int number)
        {
            string num = "";
            int reversedNum;

            while (number > 0)
            {
                reversedNum = number % 10;
                number = number / 10;
                num += Convert.ToString(reversedNum);
            }

            reversedNum = Convert.ToInt32(num);
            Console.WriteLine(reversedNum);
        }

        static int ReadNumberAndPrintedReversed(int number)
        {
            int reversedNum = 0, remainder = 0;

            while (number > 0)
            {
                remainder = number % 10;
                number = number / 10;
                reversedNum = reversedNum * 10 + remainder;
            }

            return reversedNum;
        }


        /// Problem 8, 9
        /// //////////////////////// Print Digit Frequency /////////////////

        static int DigitFrequency(int digit, int number)
        {
            int numOfDigit = 0;
            int Count = 0;

            while (number > 0) { 
                
                numOfDigit = number % 10;
                number = number / 10;

                if (numOfDigit == digit) {

                    Count++;
                }
            }

            return Count;
            //Console.WriteLine($"Digit {digit} Frequency is {Count} Time(s)");
        }

        static void PrintAllDigitFrequency(int number)
        {

            for (int i = 0; i < 10; i++) {
                
                int digitFrequency = 0;
                digitFrequency = DigitFrequency(i, number);

                if (digitFrequency > 0) {

                    Console.WriteLine($"Digit {i} Frequency is {digitFrequency} Time(s)");
                }
            }
        }

        /// Problem 10
        /// //////////////////////// Print Number in order from left to right /////////////////

        static void PrintNumberInOrderFromLeftToRight(int number)
        {
            int num = ReadNumberAndPrintedReversed(number);
            PrintReversedNumber(num);
        }





        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////// Problem Solving From 11 to 20 //////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        static bool isBalindromeNumber(int number)
        {
            if (number == ReadNumberAndPrintedReversed(number))
            {
                return true;
            }

            return false;
        }

        static void PrintIsBalindromeNumberOrNot(int number)
        {
            if (isBalindromeNumber(number))
            {

                Console.WriteLine("Yes, it is a Palindrome Number.");
            }
            else
            {

                Console.WriteLine("No, it is Not Palindrome Number.");
            }
        }

        static void PrintInvertedPatternAsFollows(int number)
        {
            //int num = number;

            //for (int i = 0; i < number; i++) {

            //    for (int j = 0; j < num; j++) {

            //        Console.Write(num);
            //    }

            //    num--;
            //    Console.WriteLine();
            //}


            for (int i = number; i >= 1; i--)
            {

                for (int j = 0; j < i; j++)
                {

                    Console.Write(i);
                }

                Console.WriteLine();
            }
        }

        static void PrintNumberPattern(int number)
        {
            for(int i = 1; i <= number; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    Console.Write(i);
                }

                Console.WriteLine();
            }
        }

        static void PrintInvertedLetterPattern(int number)
        {
            for (int i = number; i >= 1; i--)
            {

                for (int j = 0; j < i; j++)
                {

                    Console.Write(Convert.ToChar(i + 64));
                }

                Console.WriteLine();
            }
        }

        static void PrintLetterPattern(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(Convert.ToChar(i + 64));
                }

                Console.WriteLine();
            }
        }

        static void PrintFromAAAToZZZ()
        {
            string letters = "";

            for(int i = 65; i < 91; i++)
            {
                for (int j = 65; j < 91; j++)
                {
                    for (int a = 65; a < 91; a++)
                    {
                        letters += Convert.ToString(Convert.ToChar(i));
                        letters += Convert.ToString(Convert.ToChar(j));
                        letters += Convert.ToString(Convert.ToChar(a));
                        Console.WriteLine(letters);
                        letters = "";
                    }
                }
            }
        }

        static string guess3LetterPassword(string password)
        {
            string letters = "";

            for (int i = 65; i < 91; i++)
            {
                for (int j = 65; j < 91; j++)
                {
                    for (int a = 65; a < 91; a++)
                    {
                        letters += Convert.ToString(Convert.ToChar(i));
                        letters += Convert.ToString(Convert.ToChar(j));
                        letters += Convert.ToString(Convert.ToChar(a));
                        Console.WriteLine($"Trial [{a - 64}]: {letters}");

                        if(password == letters)
                        {
                            Console.WriteLine($"\n\nPassword is {letters}");
                            Console.WriteLine($"Found after {a - 64} Trial(s)");
                            return letters;
                        }

                        letters = "";
                    }
                }
            }

            return letters;
        }

        static string encryptString(string str)
        {
            string encrypt = "";

            for (int i = 0; i < str.Length; i++)
            {

                encrypt += Convert.ToChar(str[i] + 2);
            }

            return encrypt;
        }

        static string decryptString(string str)
        {
            string decrypt = "";

            for (int i = 0; i < str.Length; i++)
            {

                decrypt += Convert.ToChar(str[i] - 2);
            }

            return decrypt;
        }






        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////// Problem Solving From 21 to 30 //////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

















        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////// Problem Solving From 31 to 40 //////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        static void Main(string[] args)
        {


            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////// Problem Solving From 1 to 10 //////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////




            /// //////////////////////// Prime Numbers From 1 to N/////////////////

            //PrintPeimeNumbersFrom1ToN(ReadPositiveNumber("Enter Number: "));


            /// //////////////////////// if the Number is a Perfect Number or Not /////////////////

            //PrintPerfectResult(ReadPositiveNumber("Enter Number: "));

            //PrintPerfectNumberFrom1ToN(ReadPositiveNumber("Enter Number: "));

            /// Problem 
            /// //////////////////////// Print Reversed Number /////////////////

            //PrintReversedNumber(ReadPositiveNumber("Enter Number: "));

            /// Problem 
            /// //////////////////////// Print the sum of digits of its Number /////////////////

            //PrintTheDigitsOfNumber(ReadPositiveNumber("Enter Number: "));

            /// Problem 
            /// //////////////////////// Read Number And Printed Reversed /////////////////

            //ReadNumberAndPrintedReversedUsingString(ReadPositiveNumber("Enter Number: "));
            //Console.WriteLine(ReadNumberAndPrintedReversed(ReadPositiveNumber("Enter Number: ")));

            /// Problem 
            /// //////////////////////// Print Digit Frequency /////////////////

            //PrintDigitFrequency(ReadPositiveNumber("Enter Digit: "), ReadPositiveNumber("Enter Number: "));
            //PrintAllDigitFrequency(ReadPositiveNumber("Enter Number: "));


            /// Problem 10
            /// //////////////////////// Read Number And Printed Reversed /////////////////


            //PrintNumberInOrderFromLeftToRight(ReadPositiveNumber("Enter Number: "));






            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////// Problem Solving From 11 to 20 //////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            //PrintIsBalindromeNumberOrNot(ReadPositiveNumber("Enter Number: "));

            //PrintInvertedPatternAsFollows(ReadPositiveNumber("Enter Number: "));

            //PrintNumberPattern(ReadPositiveNumber("Enter Number: "));

            //PrintInvertedLetterPattern(ReadPositiveNumber("Enter Number: "));

            //PrintLetterPattern(ReadPositiveNumber("Enter Number: "));

            //PrintFromAAAToZZZ();

            //guess3LetterPassword("AAA");

            //string a = "Mohammed";
            //Console.WriteLine(a);
            //a = encryptString(a);
            //Console.WriteLine(a);
            //a = decryptString(a);
            //Console.WriteLine(a);

            //for (int i = 0; i < 25; i++)
            //{

                //Console.WriteLine(clsRandom.RandomNumbers(1, 35));



                //Console.WriteLine(clsRandom.GetRandomCharacter(clsRandom.enRandomChar.SmallLetter));
                //Console.WriteLine(clsRandom.GetRandomCharacter(clsRandom.enRandomChar.CapitalLetter));
                //Console.WriteLine(clsRandom.GetRandomCharacter(clsRandom.enRandomChar.SpecialCharacter));
                //Console.WriteLine(clsRandom.GetRandomCharacter(clsRandom.enRandomChar.Digit));
                //Console.WriteLine();
                //Console.WriteLine();
                //Console.WriteLine();
            //}



            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////// Problem Solving From 21 to 30 //////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
   















            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////// Problem Solving From 31 to 40 //////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            Console.ReadKey();
        }
    }
}
