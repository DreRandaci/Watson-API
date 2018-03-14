﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackendWatsonApi.Models
{
    public class UserPost
    {
        [Key]
        public int UserPostId { get; set; }

        [Required]
        public User User { get; set; }

        [Required]
        public Place Place { get; set; }

        public virtual ICollection<WatsonClassification> Classifications { get; set; }

        [Required]
        public int ImageId { get; set; }

        [Required]
        public DateTime DateAdded { get; set; }
    }
}
