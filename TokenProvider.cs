using Group2.context;
using Group2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Group2
{
    public class TokenProvider
    {
        hackertonDbContext _context;

        public TokenProvider(hackertonDbContext context)
        {
            _context = context;
        }
        public string LoginUser(string serviceNo, string password)
        {
            string username = serviceNo;
            string pass = password;

            var user = _context.doc_Res.SingleOrDefault(x => x.serviceNo == username && x.PASSWORD == pass);

            //Authenticate User, Check if its a registered user in DB  - JRozario
            if (user == null)
                return null;
         
           
            var key = Encoding.ASCII.GetBytes("YourKey-2374-OFFKDI940NG7:56753253-tyuw-5769-0921-kfirox29zoxv");

            var JWToken = new JwtSecurityToken(
                issuer: "",
                audience: "",
                claims: GetUserClaims(user),
                notBefore: new DateTimeOffset(DateTime.Now).DateTime,
                expires: new DateTimeOffset(DateTime.Now.AddDays(1)).DateTime,

                signingCredentials: new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            );
            var token = new JwtSecurityTokenHandler().WriteToken(JWToken);
         
            return token;
        }
        private IEnumerable<Claim> GetUserClaims(Doc_Res user)
        {
            List<Claim> claims = new List<Claim>();
            Claim _claim;
            _claim = new Claim(ClaimTypes.Name, user.serviceNo);
            claims.Add(_claim);

            _claim = new Claim(ClaimTypes.Role, user.ROLE);
            claims.Add(_claim);

            return claims.AsEnumerable<Claim>();
        }
    }
}
