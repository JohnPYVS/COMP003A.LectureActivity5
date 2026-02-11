namespace COMP003A.LectureActivity5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DisplayWelcome();

            string name = "Alex";
            int age = 20;
            DisplayUserInfo(name, age);

            int sum = CalculateSum(7, 8);
            Console.WriteLine("The sum is: " + sum);

            int mainOnlyNumber = 55;

            if (true)
            {
                int insideIf = 6;
                Console.WriteLine(insideIf);
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(i);
            }

            static void DisplayWelcome()
            {
                Console.WriteLine("Welcome to Module 5!");
            }

            static void DisplayUserInfo(string name, int age)
            {
                Console.WriteLine("Name: " + name + ", Age: " + age);
            }

            static int CalculateSum(int a, int b)
            {
                return a + b;
            }
            /* Method variables are not accessible in Main because they are only local to that method
             * 
             * Block variables do not exist outside {} so it won't share the methods inside variables 
             * it is only to pass the values using the parameters or return values
             * 
             * Why scope improves program safety is because it helps prevents accidental changes
             * and with that you can reuse names safely
             */
        }
    }
}
