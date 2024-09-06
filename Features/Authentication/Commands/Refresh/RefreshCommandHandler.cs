using Intelificio_Back.Common.Response;
using Intelificio_Back.Features.Authentication.Common;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace Intelificio_Back.Features.Authentication.Commands.Refresh
{
    public class RefreshCommandHandler(UserManager<User> userManager, IJwtService jwtService, IConfiguration configuration) : IRequestHandler<RefreshCommand, Result>
    {
        public async Task<Result> Handle(RefreshCommand request, CancellationToken cancellationToken)
        {
            var principals = jwtService.GetPrincipalFromExpiredToken(request.Token);

            var user = await userManager.FindByEmailAsync(principals.Claims.Where(e => e.Type.Equals(ClaimTypes.Email)).First().Value);

            if (!user.RefreshToken.Equals(request.RefreshToken) && user.RefreshTokenExpiration <= DateTime.Now)
            {
                user.RefreshToken = null;
                user.RefreshTokenExpiration = null;
                var responseRevokeRefresh = await userManager.UpdateAsync(user);
                if (responseRevokeRefresh.Succeeded)
                {
                    return Result.Failure(AuthenticationErrors.RefreshTokenExpired);
                }
                else
                {
                    var errorList = new List<string>();
                    foreach (var error in responseRevokeRefresh.Errors)
                        errorList.Add(error.Description);
                    return Result.Failure(AuthenticationErrors.RefreshTokenError(errorList));
                }
            }

            var newToken = jwtService.CreateToken(principals.Claims);
            var refreshToken = jwtService.GenerateRefreshToken();

            user.RefreshToken = refreshToken;
            user.RefreshTokenExpiration = DateTime.Now.AddMinutes(configuration.GetValue<double>("Authentication:Schemes:Bearer:RefreshTokenValidityInDays"));
            var response = await userManager.UpdateAsync(user);
            if (response.Succeeded)
            {
                return Result.SuccessWithResponse(new AZ_204.Common.Response.ResponseData
                {
                    Data = new RefreshCommandResponse
                    {
                        Token = newToken,
                        RefreshToken = refreshToken
                    }
                });
            }
            else
            {
                var errorList = new List<string>();
                foreach (var error in response.Errors)
                    errorList.Add(error.Description);
                return Result.Failure(AuthenticationErrors.RefreshTokenError(errorList));
            }
        }
    }
}
