namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var singletonOne = Singleton.GetInstance();
            var singletonTwo = Singleton.GetInstance();
        }
    }
}
