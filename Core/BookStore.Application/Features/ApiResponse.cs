namespace BookStore.Application.Features
{
    public class ApiResponse<T> where T : class
    {
        public bool IsSuccess { get; set; } = true;
        public T Data { get; set; } = null;
        public string Message { get; set; } = "";
    }
}