namespace jlu_api_rest.Api.Models
{
    public class ResultData<T> : Result
    {
        public T Data { get; set; }
    }
}