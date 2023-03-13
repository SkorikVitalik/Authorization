using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace Application;
public class ServiceAuthorization
{
    public string GetAccessToken(User user, string Secutirykey, int ExpiryMinutes, string? issuer = null, string? audience = null )
    {

        var claims = new Claim[]
        {
            new Claim(JwtRegisteredClaimNames.Sub, "Access"),
            new Claim(JwtRegisteredClaimNames.UniqueName, user.Login),
            new Claim(JwtRegisteredClaimNames.Email, user.Email)
        };
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Secutirykey));
        var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature);
        var JwtSecurityToken = new JwtSecurityToken(issuer, audience, claims, expires:DateTime.UtcNow.AddMinutes(ExpiryMinutes), signingCredentials:credentials);
        var jwtToken = new JwtSecurityTokenHandler().WriteToken(JwtSecurityToken);
        return jwtToken;
    }
    public string GetRefreshToken(User user)
    {
        var security = Convert.ToBase64String(RandomNumberGenerator.GetBytes(64));
        return security; 
    }
}
