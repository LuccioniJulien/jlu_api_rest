namespace jlu_api_rest.Services.Interfaces
{
    public interface IServices<T>
    {
        T Get(int id);
        T Post(T data);
        T Put(T data);
        T Delete(int id);
    }
}
