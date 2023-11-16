namespace LMS.Application.Services.Authentication
{
    public interface IAuthenticationService
    {
        public ValueTask<string> TokenGenerateAsync();
    }
}
