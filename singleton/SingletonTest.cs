namespace dotnet_console_template.singleton
{
    public class SingletonTest
    {
        private static SingletonTest? instance;
        private static int counter = 0;

        public static SingletonTest GetSingletonTest
        {
            get => instance ??= new SingletonTest();
        }

        protected SingletonTest()
        {
            counter++;
            Console.WriteLine($"Counter value {counter}");
        }
    }

    public class Employee : SingletonTest
    {
        public string PrintDetails() => "EMpl";
    }

    public class Employee1 : SingletonTest
    {
        public string PrintDetails() => "EMpl2";
    }
}
