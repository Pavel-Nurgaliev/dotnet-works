using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class UsersRewards
    {
        public int UserId { get; set; }
        public int RewardId { get; set; }
        public string RewardTitle { get; set; }
    }
}
