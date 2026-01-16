namespace NonVoid2
{
    internal class Program
    {
        public class NonVoid2
        {
            /// <summary>
            /// Returns the square of num.
            /// </summary>
            /// <param name="num">The number to be squared</param>
            /// <returns>The square of num</returns>
            public int Square(int num)
            {
                // TODO : Implement square calculation
                return num*num;
                throw new NotImplementedException();
            }

            /// <summary>
            /// Returns the sum of num1, num2, and num3.
            /// </summary>
            /// <param name="num1">First number in the sum</param>
            /// <param name="num2">Second number in the sum</param>
            /// <param name="num3">Third number in the sum</param>
            /// <returns>The sum of num1, num2, and num3</returns>
            public int SumThree(int num1, int num2, int num3)
            {
                // TODO : Implement sum of three numbers
                int sum = num1 + num2+num3;
                return sum;
                throw new NotImplementedException();
            }

            /// <summary>
            /// Returns the smaller value between num1 and num2.
            /// </summary>
            /// <param name="num1">First number in minimum comparison</param>
            /// <param name="num2">Second number in minimum comparison</param>
            /// <returns>The smaller value</returns>
            public int Smaller(int num1, int num2)
            {
                // TODO : Implement minimum comparison
                if (num1 > num2)
                {
                    return num2;
                }
                else
                {
                    return num1;
                }
                throw new NotImplementedException();
            }

            /// <summary>
            /// Returns one of five fortune cookie responses chosen at random.
            /// If the random number = 0 the method returns "Your future looks bright"
            /// If the random number = 1 the method returns "I see love in your future"
            /// If the random number = 2 the method returns "Maybe you better stay home today"
            /// If the random number = 3 the method returns "You will have fame and fortune"
            /// If the random number = 4 the method returns "Happiness you will have"
            /// </summary>
            /// <returns>A string response</returns>
            public string FortuneCookie()
            {
                int num = new Random().Next(0, 5);
                // TODO : Return fortune cookie response based on random number

                throw new NotImplementedException();
            }

            /// <summary>
            /// Returns a response depending upon month's value.
            /// If month >= 1 && month <= 3 it returns "winter"
            /// If month >= 4 && month <= 6 it returns "spring"
            /// If month >= 7 && month <= 9 it returns "summer"
            /// If month >= 10 && month <= 12 it returns "fall"
            /// </summary>
            /// <param name="month">The numerical month of the year</param>
            /// <returns>A string response</returns>
            public string Season(int month)
            {
                // TODO : Return season based on month value
                if (1 <= month && month <= 3)
                {
                    return "winter";
                }
                else if (4 <= month && month <= 6)
                {
                    return "spring";
                }
                else if (7 <= month && month <= 9)
                {
                    return "summer";
                }
                else if (10 <= month && month <= 12)
                {
                    return "fall";
                }
                throw new NotImplementedException();
            }

            /// <summary>
            /// Determines if num is odd or even.
            /// If num is even it returns the string "even";
            /// otherwise it returns the string "odd".
            /// </summary>
            /// <param name="num">Number used in comparison</param>
            /// <returns>The string "even" or the string "odd"</returns>
            public string EvenOdd(int num)
            {
                // TODO : Determine if number is even or odd
                throw new NotImplementedException();
            }

            public static void Main(string[] args)
            {
                NonVoid2 app = new NonVoid2();

                Console.WriteLine("Test square method");
                Console.WriteLine("==================");
                Console.WriteLine("The square of 5 is " + app.Square(5));
                Console.WriteLine("The square of 12 is " + app.Square(12));

                Console.WriteLine();
                Console.WriteLine("Test sumThree method");
                Console.WriteLine("====================");
                Console.WriteLine("The sum of 10, 20, 30 is " + app.SumThree(10, 20, 30));
                Console.WriteLine("The sum of 15, 100, 75 is " + app.SumThree(15, 100, 75));

                Console.WriteLine();
                Console.WriteLine("Test smaller method");
                Console.WriteLine("====================");
                Console.WriteLine("Which is smaller 10 or 35? " + app.Smaller(10, 35));
                Console.WriteLine("Which is smaller 100 or 50? " + app.Smaller(100, 50));

                Console.WriteLine();
                Console.WriteLine("Test fortuneCookie method");
                Console.WriteLine("=========================");
                Console.WriteLine("Your fortune cookie says - " + app.FortuneCookie());
                Console.WriteLine("Your fortune cookie says - " + app.FortuneCookie());

                Console.WriteLine();
                Console.WriteLine("Test season method");
                Console.WriteLine("===================");
                Console.WriteLine("The month of March is in the " + app.Season(3));
                Console.WriteLine("The month of July is in the " + app.Season(7));

                Console.WriteLine();
                Console.WriteLine("Test evenOdd method");
                Console.WriteLine("===================");
                Console.WriteLine("The number 84 is " + app.EvenOdd(84));
                Console.WriteLine("The number 27 is " + app.EvenOdd(27));
            }
        }
    }
}