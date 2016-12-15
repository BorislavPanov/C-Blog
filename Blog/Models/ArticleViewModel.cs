﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Blog.Models
{
    public class ArticleViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        public string Content { get; set; }

        [Required]
        public string AuthorId { get; set; }

        public int CategoryId { get; set; }

        public ICollection<Article> Article { get; set; }

        public List<Category> Categories { get; internal set; }

        public string Tags { get; set; }
    }
}