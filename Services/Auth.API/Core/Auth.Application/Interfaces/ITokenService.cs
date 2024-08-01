using Auth.Application.DTOs;
using Auth.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auth.Application.Interfaces
{
    public interface ITokenService
    {
        Token CreateToken(AppUser user, IList<string> roles);
       
    }
}
