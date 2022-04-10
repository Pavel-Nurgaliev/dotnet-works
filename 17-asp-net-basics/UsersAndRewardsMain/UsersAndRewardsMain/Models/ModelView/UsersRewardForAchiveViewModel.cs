﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UsersAndRewardsMain.Models.ModelView
{
    public class UsersRewardsForAchiveEditViewModel
    {
        public int UserId { get; set; }
        [Required]
        [Remote("AchiveUser", "User")]
        public int RewardId { get; set; }
        public string RewardTitle { get; set; }
    }
}
