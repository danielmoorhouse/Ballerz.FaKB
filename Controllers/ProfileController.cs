using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Ballerz.Football.Data;
using Ballerz.Football.Models;
using Ballerz.Football.Models.Profile;
//using Ballerz.Football.Profile;
//using Ballerz.Football.Profile;
using Ballerz.Football.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Ballerz.Football.Controllers
{
    public class ProfileController : Controller
    {
         
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IApplicationUser _userService;
        private readonly IProfile _profileService;
        private readonly IClubs _clubService;
        private readonly ICountries _countriesService;
        private readonly ApplicationDbContext _db;

        public ProfileController(
            UserManager<ApplicationUser> userManager, 
            IApplicationUser userService,
            IProfile profileService,
            ApplicationDbContext db,
            IClubs clubService,
            ICountries countriesService)
        {
            _userManager = userManager;
            _userService = userService;
            _db = db;
            _profileService = profileService;
            _clubService = clubService;
            _countriesService = countriesService;
        }

        public IActionResult Detail(string id)
        {
            
            var user = _userService.GetAll().Where(u => u.Id == id).FirstOrDefault();
            var profile = _db.Profile.Where(p => p.UserId == id).FirstOrDefault();
            var userRoles = _userManager.GetRolesAsync(user).Result;

            var model = new ProfileDetailModel()
            {
                UserId = user.Id,
                FirstName = profile.FirstName,
                LastName = profile.LastName,
                UserName = user.UserName,
                ShortDescription = profile.ShortDescription,
                TeamId = profile.ClubId,
                TeamName = _clubService.GetAll().Where(c => c.Id == profile.ClubId).FirstOrDefault().ClubName,
                TeamBadgeUrl = _clubService.GetAll().Where(c => c.Id == profile.ClubId).FirstOrDefault().TeamBadgeUrl,
                CountryId = profile.CountryId,
                CountryName = _countriesService.GetAll().Where(f => f.Id == profile.CountryId).FirstOrDefault().CountryName,
                CountryFlagUrl = _countriesService.GetAll().Where(f => f.Id == profile.CountryId).FirstOrDefault().FlagUrl,
                Location = profile.Location,
                IsAdmin = userRoles.Contains("Site Admin"),
                UserRating = _userService.GetAll().Where(s => s.Id == id).FirstOrDefault().Rating.ToString(),
                ProfileImageUrl = profile.ProfileImageUrl,
                MemberSince = profile.MemberSince
                
         
            };

            return View(model);
        }

    
                public async Task<IActionResult> Create(int id)
        {

            var user = await _userManager.FindByNameAsync(User.Identity.Name);
             var model = new AddProfileModel();
            {
           
            var teams = _db.Clubs.OrderBy(c => c.ClubName)
                                        .Select(x => new { Id = x.Id, Value = x.ClubName });
            model.TeamList = new SelectList(teams, "Id", "Value");

            var countries = _db.Countries.OrderBy(c => c.CountryName)
                                       .Select(x => new { Id = x.Id, Value = x.CountryName });

            model.CountryList = new SelectList(countries, "Id", "Value");
            

            model.UserId = user.Id;

            }
        

            return View(model);

        }
        [HttpPost]
        public async Task<IActionResult> AddProfile(AddProfileModel model, IFormCollection image1)
        {
         
             var userId = _userManager.GetUserId(User);

            var user = _userManager.FindByIdAsync(userId).Result;
            string storePath = "/images/profile_images/";
            var path = Path.Combine(
                     Directory.GetCurrentDirectory(), "wwwroot", "images", "profile_images",
                     image1.Files[0].FileName);

            using (var stream = new FileStream(path, FileMode.Create))
            {
                await image1.Files[0].CopyToAsync(stream);

            }
            var profile = new Data.Profile
            {
                Id = model.Id,
                UserId = model.UserId,
                FirstName = model.FirstName,
                LastName = model.LastName,
                ClubId = model.TeamId,
                ShortDescription = model.ShortDescription,
                CountryId = model.CountryId,
                Location = model.Location,
                MemberSince = DateTime.Now,
                ProfileImageUrl = storePath + model.ImageUpload.FileName
          


            };
            await _profileService.Create(profile);
             return RedirectToAction("Detail", "Profile", new { id = userId });

        }

        //[Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            var profiles = _userService.GetAll()
                .OrderByDescending(user => user.Rating)
                .Select(u => new ProfileListingModel
                {
                    Id = u.Id,
                    FirstName = u.LastName,
                    ProfileImageUrl = u.ProfileImageUrl,
                    UserRating = u.Rating.ToString(),
                    MemberSince = u.MemberSince
                });

            var model = new ProfileIndexModel
            {
                Profiles = profiles
            };

            return View(model);
        }
    }
}
  