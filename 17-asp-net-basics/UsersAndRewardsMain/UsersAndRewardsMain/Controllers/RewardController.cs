using Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using UsersAndRewardsMain.Models.ModelView;
using UsersAndRewardsSQL;

namespace UsersAndRewardsMain.Controllers
{
    public class RewardController : Controller
    {
        private DataBaseDAO _data;
        public RewardController()
        {
            string connectionStringBuilder = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            _data = new DataBaseDAO(connectionStringBuilder);
        }
        public IActionResult Rewards()
        {
            var rewards = _data.GetAllRewards();

            return View(rewards);
        }
        public IActionResult AddNewReward()
        {
            _data.AddNewReward();

            return RedirectToAction("Rewards");
        }
        [HttpPost]
        public IActionResult DeleteReward(int rewardID)
        {
            _data.DeleteReward(rewardID);

            return RedirectToAction("Rewards");
        }
        [HttpPost]
        public IActionResult GetThisReward(int rewardID)
        {
            var reward = _data.GetThisReward(rewardID);

            var rewardVM = new RewardEditViewModel
            {
                ID = reward.ID,
                Title = reward.Title,
                Description = reward.Description
            };

            return View(rewardVM);
        }
        [HttpPost]
        public IActionResult EditReward(RewardEditViewModel rewardVM)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("ErrorView", "User");
            }

            var reward = new Reward
            {
                ID = rewardVM.ID,
                Title = rewardVM.Title,
                Description = rewardVM.Description
            };

            _data.EditReward(reward.ID, reward);

            return View(reward);
        }
    }
}
