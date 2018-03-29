﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendWatsonApi.Models
{
    public class UserPostDetail
    {
        /* Used for saving user post details after an image has been saved. 
         * Has all the properties needed for each model reference used in the UserPostController.          
        */

        public string Address { get; set; }

        public string Notes { get; set; }

        public int? UserId { get; set; }

        public double? Latitude { get; set; }

        public double? Longitude { get; set; }

        public int ImgId { get; set; }

        public DateTime? DateAdded { get; set; }

        public virtual ICollection<WatsonClassification> Classifications { get; set; }
    }
}
