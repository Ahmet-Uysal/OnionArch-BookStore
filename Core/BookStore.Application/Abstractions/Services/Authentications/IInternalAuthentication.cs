namespace BookStore.Application.Abstractions.Services.Authentications
{
    public interface IInternalAuthentication
    {
        Task<Dtos.Token> LoginAsync(string usernameOrEmail, string password, int accessTokenLifeTime);
    }
}