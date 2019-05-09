using System;
using System.Linq;
using System.Threading.Tasks;
using Ballerz.Football.Data;
using Ballerz.Football.Forums.Models;
using Ballerz.Football.Models.Reply;
using Ballerz.Football.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Ballerz.Football.Controllers
{
    [Authorize]
    public class ReplyController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly IPost _postService;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IApplicationUser _userService;
        private readonly IProfile _profileService;

        public ReplyController(ApplicationDbContext db, IPost postService, 
            UserManager<ApplicationUser> userManager,
            IApplicationUser userService, IProfile profileService)
        {
            _postService = postService;
            _userManager = userManager;
            _userService = userService;
            _profileService = profileService;
            _db = db;
        }

        public IActionResult Create(int id)
        {
            var post = _postService.GetById(id);
            var user = _userService.GetAll().Where(us => us.UserName == User.Identity.Name).FirstOrDefault();
            var profile = _profileService.GetByUserId(user.Id);
            var model = new PostReplyModel
            {
                PostContent = post.Content,
                PostTitle = post.Title,
                PostId = post.Id,

                AuthorId = user.Id,
                AuthorName = User.Identity.Name,
                AuthorImageUrl = profile.ProfileImageUrl,
                AuthorRating = user.Rating,
                IsAuthorAdmin = User.IsInRole("Site Admin"),

                ForumId = post.Forum.Id,
                ForumName = post.Forum.Title,
                ForumImageUrl = post.Forum.ImageUrl,

                Created = DateTime.Now
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddReply(PostReplyModel model)
        {
            var userId = _userManager.GetUserId(User);
            var user = await _userManager.FindByIdAsync(userId);

            var reply = BuildReply(model, user);

            await _postService.AddReply(reply);
            await _userService.UpdateUserRating(userId, typeof(PostReply));

            return RedirectToAction("Index", "Post", new { id = model.PostId });
        }

        private PostReply BuildReply(PostReplyModel model, ApplicationUser user)
        {
            var post = _postService.GetById(model.PostId);

            return new PostReply
            {
                Post = post,
                Content = model.ReplyContent,
                ReplyAuthorImage = model.AuthorImageUrl,
                Created = DateTime.Now,
                User = user
            };
        }        
    }
}