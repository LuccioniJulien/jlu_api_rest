namespace jlu_api_rest.Api.Models
{
    public struct Result<T>
    {
        public T Data { get; set; }
        public int Status { get; set; }
    }
}