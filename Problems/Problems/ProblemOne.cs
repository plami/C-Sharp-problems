namespace Problems
{
    using System;

    public class ProblemOne
    {
        public static void Main()
        {
            for (int j = 1; j <= 100; j++)
            {
                string output = string.Empty;

                if (j % 3 == 0)
                {
                    output = "Fizz"; // The output is divisible by 3 --> Fizz
                }

                if (j % 7 == 0)
                {
                    output += "Buzz"; // The output is divisible by 7 --> Buzz
                }

                if (output == string.Empty)
                {
                    output = j.ToString();
                }

                Console.WriteLine(output);
            }
        }
    }
}
