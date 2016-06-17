namespace DIWebApiTest.Models
{
    public class IdProvider : IIdProvider
    {
        private int _id = 1;

        public int Next()
        {
            return _id++;
        }
    }
}