using Newtonsoft.Json;

namespace MyTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 5.5f;
            var j = JsonConvert.SerializeObject(a);
            var b = JsonConvert.DeserializeObject(j);
            Console.WriteLine("{0}", b?.GetType());
        }
    }
}
