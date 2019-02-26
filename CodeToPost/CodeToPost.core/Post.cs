using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CodeToPost.core
{
    public class Post
    {
        public int Id { get; set; }
        [Required, StringLength(80)]

        public string Name { get; set; }
        [Required, StringLength(225)]

        public string Message { get; set; }
    }
}