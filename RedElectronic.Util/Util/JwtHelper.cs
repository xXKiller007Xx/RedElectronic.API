using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json.Linq;

namespace RedElectronic.Util.Util
{
    /// <summary>
    /// Class for reading, creating, parsing with JWT Token
    /// </summary>
    public static class JwtHelper
    {
        /// <summary>
        /// Create Jwt Token
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="secretKey"></param>
        /// <param name="issuer"></param>
        /// <param name="audience"></param>
        /// <param name="algorithms"></param>
        /// <returns></returns>
        public static string CreateJwtToken(JObject obj, string secretKey, string issuer, string audience, string algorithms)
        {
            return "";
        }
    }
}
