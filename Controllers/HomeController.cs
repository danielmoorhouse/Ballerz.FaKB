using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ballerz.Football.Models;
using Ballerz.Football.Data;
using Ballerz.Football.Services;
using Ballerz.Football.Models.Clubs;
using Ballerz.Football.Models.Post;
using Ballerz.Football.Models.Profile;
using Ballerz.Football.Models.Home;
using Ballerz.Football.Models.Forum;
using Ballerz.Football.Forums.Models;

namespace Ballerz.Football.Ballerz.Web.Controllers
{
    public class HomeController : Controller
    {
          private readonly IPost _postService;
          private readonly IApplicationUser _userService;
          private readonly IClubs _clubService;
          private readonly ApplicationDbContext _db;

         public HomeController(IPost postService, IApplicationUser userService, ApplicationDbContext db, IClubs clubService)
        {
            _postService = postService;
            _userService = userService;
            _db = db;
            _clubService = clubService;
        }
        public IActionResult Index()
        {
            var model = BuildHomeIndexModel();
            return View(model);
        }
         private HomeIndexModel BuildHomeIndexModel()
        {
            var latestPosts = _postService.GetLatestPosts(10);
           // var username = _userService.GetAll().Where(u => u.Id == )
            var users = (from u in _db.Profile.ToList().Take(10)
                        .OrderByDescending(m => m.MemberSince)
                        join c in _db.Countries on u.CountryId equals c.Id
                        join t in _db.Clubs on u.ClubId equals t.Id
                        select new ProfileListingModel {
                           UserId =  u.UserId,
                              
                               Location = u.Location, 
                              ProfileImageUrl = u.ProfileImageUrl,
                               MemberSince =  u.MemberSince, 
                               FlagUrl =  c.FlagUrl,
                               TeamBadge = t.TeamBadgeUrl
                                 });
                       
         

            var posts = latestPosts.Select(post => new PostListingModel
            {
                Id = post.Id,
                Title = post.Title,
                AuthorName = post.User.UserName,
                AuthorId = post.User.Id,
                AuthorRating = post.User.Rating,
                DatePosted = post.Created.ToString(),
                RepliesCount = post.Replies.Count(),
                Forum = GetForumListingForPost(post)
            });
            var teams =  _clubService.GetAll().Take(6)
                        .OrderByDescending(r => r.WorldwideFans)
                        .Select(c => new ClubListingModel
                        {
                            ClubName = c.ClubName,
                            TeamBadgeUrl = c.TeamBadgeUrl,
                            WorldwideFans = c.WorldwideFans
                        });
                    var attendance =  _clubService.GetAll().Take(6)
                        .OrderByDescending(r => r.AverageAttendance)
                        .Select(c => new ClubListingModel
                        {
                            ClubName = c.ClubName,
                            TeamBadgeUrl = c.TeamBadgeUrl,
                            AverageAttendance = c.AverageAttendance
                        });            

            return new HomeIndexModel
            {
                LatestPosts = posts,
                SearchQuery = "",
                Profile = users,
                Teams = teams,
                Attendance = attendance
                //UserName = users
                
            };
        }
        private ForumListingModel GetForumListingForPost(Post post)
        {
            var forum = post.Forum;

            return new ForumListingModel
            {
                Id = forum.Id,
                Name = forum.Title,
                ImageUrl = forum.ImageUrl
            };
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
