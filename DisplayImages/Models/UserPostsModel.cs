﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DisplayImages.Models
{
    public class UserPostsModel
    {
        public int  userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string body { get; set; }

    }
}