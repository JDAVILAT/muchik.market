using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace muchik.market.infrastructure.crosscutting.Jwt
{
    internal interface IJwtManager
    {
        string GenerateToken(string userId, string username, string customerId, string role);
    }
}
