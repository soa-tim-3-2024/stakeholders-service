using Explorer.Stakeholders.API.Public;
using Grpc.Core;
using GrpcServiceTranscoding;

namespace Explorer.API.Controllers.Proto
{
    public class AuthenticationProtoController : Authorize.AuthorizeBase
    {
        private readonly ILogger<AuthenticationProtoController> _logger;
        private readonly IAuthenticationService _authenticationService;

        public AuthenticationProtoController(ILogger<AuthenticationProtoController> logger, IAuthenticationService authenticationService)
        {
            _logger = logger;
            _authenticationService = authenticationService;
        }

        public override async Task<AuthenticationTokens> Authorize(Credentials request,
            ServerCallContext context)
        {
            //var credentials = new Stakeholders.API.Dtos.CredentialsDto { Password = request.Password, Username = request.Username };
            var credentials = new Stakeholders.API.Dtos.CredentialsDto { Password = "somi", Username = "somi" };
            var result = _authenticationService.Login(credentials);

            //PROBLEM
            AuthenticationTokens test = new AuthenticationTokens();
            //test.AccessToken = result.Value.AccessToken;
            //test.Id = result.Value.Id;
            return await Task.FromResult(test);




        }
    }
}
