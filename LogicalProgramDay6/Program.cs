namespace LogicalProgramDay6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            LogicalProgram obj = new LogicalProgram();
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    obj.FibonacciSeries();
                    break;
                case 2:
                    obj.Palindrome();
                    break;
                case 3:
                    obj.PerfectNum();
                    break;
                case 4:
                    obj.ReverseString();
                    break;
                case 5:
                    obj.ReverseNumber();
                    break;
                case 6:
                    obj.CouponNumber();
                    break;
                case 7:
                    obj.StopWatchProgram();
                    break;
            }
        }
    }
}