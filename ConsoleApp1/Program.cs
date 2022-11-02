namespace FirstApp
{
    public class Logic
    {
        public static int GetMaximum(int number)
        {
            int maxdigit = 0;
            if ((number % 10) > maxdigit)
            {
                maxdigit = number % 10;
            }
            number = number / 10;
            if ((number % 10) > maxdigit)
            {
                maxdigit = number % 10;
            }
            number = number / 10;
            if (number > maxdigit)
            {
                maxdigit = number;
            }
            return maxdigit;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите трёхзначное число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int maxdigit = Logic.GetMaximum(number);

            Console.WriteLine(maxdigit);
        }
    }
}

