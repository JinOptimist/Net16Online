﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalAboutEverything.Data.Model
{
    public class Post : BaseModel
    {
        
        public string? Message { get; set; }

        public string? Name { get; set; } 

        public DateTime? CurrentTime { get; set; }
        
        public int? LikeCount { get; set; }

        public int? DislikeCount { get; set; }

        public virtual List<User> Users { get; set; }

        public virtual List<CommentBlog> CommentsBlog { get; set; }
    }
}
