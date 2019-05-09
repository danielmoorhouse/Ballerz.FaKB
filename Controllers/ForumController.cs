using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Ballerz.Football.Forums.Models;
using Ballerz.Football.Models.Forum;
using Ballerz.Football.Models.Post;
using Ballerz.Football.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ballerz.Football.Controllers
{
    public class ForumController : Controller
    {
        private readonly IForum _forumService;
        private readonly IPost _postService;
        private readonly IProfile _profileService;

        public ForumController(IForum forumService, 
            IPost postService,            
            IProfile profileService
            )
        {
            _forumService = forumService;
            _postService = postService;
           _profileService = profileService;
        }

        public IActionResult Index()
        {
            var forums = _forumService.GetAll()
                .Select(forum => new ForumListingModel {
                    Id = forum.Id,
                    Name = forum.Title,
                    Description = forum.Description,
                    NumberOfPosts = forum.Posts?.Count() ?? 0,
                    NumberOfUsers = _forumService.GetActiveUsers(forum.Id).Count(),
                    ImageUrl = forum.ImageUrl,
                    HasRecentPost = _forumService.HasRecentPost(forum.Id)
            });

            var model = new ForumIndexModel
            {
                ForumList = forums.OrderBy(f => f.Name)
            };

            return View(model);
        }

        public IActionResult Topic(int id, string searchQuery)
        {
            var forum = _forumService.GetById(id);
            var posts = new List<Post>();

            posts = _postService.GetFilteredPosts(forum, searchQuery).ToList();

            var postListings = posts.Select(post => new PostListingModel
            {
                Id = post.Id,
                AuthorId = post.User.Id,
                AuthorRating = post.User.Rating,
                AuthorName = post.User.UserName,
                AuthorImageUrl = _profileService.GetByUserId(post.User.Id).ProfileImageUrl,
                Title = post.Title,
                DatePosted = post.Created.ToString(),
                RepliesCount = post.Replies.Count(),
                Forum = BuildForumListing(post)
            });

            var model = new ForumTopicModel
            {
                Posts = postListings,
                Forum = BuildForumListing(forum)
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Search(int id, string searchQuery)
        {
            return RedirectToAction("Topic", new { id, searchQuery });
        }

        [Authorize(Roles = "Site Admin")]
        public IActionResult Create()
        {
            var model = new AddForumModel();
            return View(model);
        }

        [HttpPost]
        [Authorize(Roles = "Site Admin")]
        public async Task<IActionResult> AddForum(AddForumModel model, IFormCollection image1)
        {
             string storePath = "/images/forum/";
            var path = Path.Combine(
                     Directory.GetCurrentDirectory(), "wwwroot", "images", "forum",
                     image1.Files[0].FileName);
            using (var stream = new FileStream(path, FileMode.Create))
           {
               await image1.Files[0].CopyToAsync(stream); 
            }

            var forum = new Forum
            {
                Title = model.Title,
                Description = model.Description,
                Created = DateTime.Now,
                ImageUrl = storePath + model.ImageUpload.FileName
            };

            await _forumService.Create(forum);
            return RedirectToAction("Index", "Forum");
        }

        // private CloudBlockBlob UploadForumImage(IFormFile file)
        // {
        //     var connectionString = _configuration.GetConnectionString("AzureStorageAccount");
        //     var container = _uploadService.GetBlobContainer(connectionString, "forum-images");
        //     var contentDisposition = ContentDispositionHeaderValue.Parse(file.ContentDisposition);
        //     var filename = contentDisposition.FileName.Trim('"');
        //     var blockBlob = container.GetBlockBlobReference(filename);
        //     blockBlob.UploadFromStreamAsync(file.OpenReadStream()).Wait();

        //     return blockBlob;
        // }

        private ForumListingModel BuildForumListing(Post post)
        {
            var forum = post.Forum;
            return BuildForumListing(forum);
        }

        private ForumListingModel BuildForumListing(Forum forum)
        {
            return new ForumListingModel
            {
                Id = forum.Id,
                Name = forum.Title,
                Description = forum.Description,
                ImageUrl = forum.ImageUrl
            };
        }
    }
}