using System.Threading.Tasks;
using Ballerz.Football.Data;

namespace Ballerz.Football.Services
{
    public interface IProfile
    {
        Data.Profile GetByUserId(string id); 

       // Profile GetByUserName(string userName);

         Task Create(Data.Profile profile);
         Task Edit(int profileId);
         Task Delete(int profileId);
    }
}