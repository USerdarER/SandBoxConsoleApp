namespace SandBoxConsoleApp.Classes
{
    public static class OddEven
    {
        public static string OddOrEven(int[] array)
        {
            return array.Sum() % 2 == 0 ? "even" : "odd";
        }
    }
}
