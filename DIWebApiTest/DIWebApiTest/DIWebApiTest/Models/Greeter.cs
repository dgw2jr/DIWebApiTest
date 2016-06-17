namespace DIWebApiTest.Models
{
    public interface IGreeter
    {
        string Greet();
    }

    public class Greeter : IGreeter
    {
        public string Greet()
        {
            return "Hello world!";
        }
    }
}