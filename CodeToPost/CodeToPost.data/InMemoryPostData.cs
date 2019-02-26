using CodeToPost.core;
using System;
using System.Collections.Generic;
using System.Linq;



namespace CodeToPost.data
{
    public class InMemoryPostData : IPostData
    {
        readonly List<Post> posts;
        public InMemoryPostData()
        {
            posts = new List<Post>()
            {
                new Post { Id = 1,Name = "Varsha",Message = "hii" },
                new Post { Id = 2, Name = "Vivaan", Message = "hello"},
                new Post { Id = 3, Name = "Varsheel", Message = "hola"},
                new Post { Id = 4, Name = "Vanshul", Message = "hey"}
            };
        }


        public Post GetById(int id)
        {
            return posts.SingleOrDefault(p => p.Id == id);
        }

        public Post Add(Post newPost)
        {
            posts.Add(newPost);
            newPost.Id = posts.Max(p => p.Id) + 1;
            return newPost;
        }

        public Post Add1(Post newPosts)
        {
            posts.Add(newPosts);
            newPosts.Id = posts.Max(p => p.Id) + 1;
            return newPosts;
        }

        public Post Update(Post updatedPost)
        {
            var post = posts.SingleOrDefault(p => p.Id == updatedPost.Id);
            if (post != null)
            {
                post.Name = updatedPost.Name;
                post.Message = updatedPost.Message;

            }
            return post;
        }

        public int Commit()
        {
            return 0;
        }

        public IEnumerable<Post> GetPostsByName(string name = null)
        {
            return from p in posts
                   where string.IsNullOrEmpty(name) || p.Name.StartsWith(name)
                   orderby p.Id
                   select p;
        }

        public Post Delete(int id)
        {
            var post = posts.FirstOrDefault(p => p.Id == id);
            if (post != null)
            {
                posts.Remove(post);
            }
            return null;
        }

        public int GetCountOfLikes()
        {
            return Likes.Count();
        }
    }
}
