﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LearningCenterWebsite.Models
{
    public class UserModel
    {
        public int Id { get; set; }

        public string Email { get; set; }
    }
}
