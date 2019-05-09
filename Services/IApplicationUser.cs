using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Ballerz.Football.Data;

namespace Ballerz.Football.Services
{
    public interface IApplicationUser
    {
        ApplicationUser GetById(string id);
        IEnumerable<ApplicationUser> GetAll();
        
        Task<ApplicationUser> GetByUsername(string userName);
        Task<ApplicationUser> GetByUsernameOrId(string userName);

        Task SetProfileImage(string id, Uri uri);
        Task UpdateUserRating(string id, Type type);
    }
}