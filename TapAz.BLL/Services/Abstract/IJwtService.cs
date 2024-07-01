using System.Security.Claims;

namespace TapAz.BLL.Services.Abstract;

public interface IJwtService
{
    /// <summary>
    /// Generates a JWT token based on the provided user ID.
    /// </summary>
    /// <param name="userId">The user's unique identifier.</param>
    /// <returns>The generated JWT token as a string.</returns>
    string GenerateToken(string userId);

    /// <summary>
    /// Validates a JWT token.
    /// </summary>
    /// <param name="token">The JWT token to validate.</param>
    /// <param name="claimsPrincipal">A <see cref="ClaimsPrincipal"/> representing the user claims if the token is valid.</param>
    /// <returns>True if the token is valid; otherwise, false.</returns>
    bool ValidateToken(string token, out ClaimsPrincipal claimsPrincipal);
}

