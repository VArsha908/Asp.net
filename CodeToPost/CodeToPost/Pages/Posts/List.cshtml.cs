using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeToPost.core;
using CodeToPost.data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace CodeToPost.Posts.Posts
{
    public class ListModel : PageModel
    {
        public readonly IConfiguration config;
        public readonly IPostData postData;

        public string Message { get; set; }
        public IEnumerable<Post>Posts{get;set;}

        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }

        public ListModel(IConfiguration config , IPostData postData)
        {
            this.config = config;
            this.postData = postData;
        }

       

        public void OnGet(string SearchTerm)
        {
            Message = config["Message"];
            Posts = postData.GetPostsByName(SearchTerm);
            Likes =
        }
    }
}