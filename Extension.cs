namespace Practice
{
    public class Base
    {
        public void Method_1()
        {
            Console.WriteLine("Method_1");
        }
        public void Method_2()
        {
            Console.WriteLine("Method_2");
        }
    }

    public static class ExtensionClass
    {
        public static int Method_3(this Base obj, int i)    //Extension Method
        {
            Console.WriteLine("Method_3... i : " + (i + 1));
            return ++i;
        }
    }

    public class Extension
    {
        public static void Main(string[] args)
        {
            Base obj = new Base();
            
            obj.Method_1();
            obj.Method_2();

            int i = obj.Method_3(4);
            Console.WriteLine(i);
        }
    }
}