namespace DIWebApiTest.Models
{
    public interface IQuery<T>
    {
        string QueryText { get; }
    }
    
    public interface ISingleQuery<T> : IQuery<T> { }
}