using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Configuration;
using UsersAndRewardsSQL;
using Entities;
using UsersAndRewardsMain.Models.ModelView;

namespace UsersAndRewardsMain.Controllers
{
    public class UserController : Controller
    {
        private DataBaseDAO _data;
        public UserController()
        {
            string connectionStringBuilder = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            _data = new DataBaseDAO(connectionStringBuilder);
        }
        public IActionResult Users()
        {
            var users = _data.GetAllUsers();

            return View(users);
        }
        public IActionResult AddNewUser()
        {
            _data.AddNewUser();

            return RedirectToAction("Users");
        }
        [HttpPost]
        public IActionResult DeleteUser(int userID)
        {
            _data.DeleteUser(userID);

            return RedirectToAction("Users");
        }
        [HttpPost]
        public IActionResult GetThisUser(int userID)
        {
            var user = _data.GetThisUser(userID);
            var userVM = new UserEditViewModel
            {
                ID = user.ID,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Bithdaydate = user.Bithdaydate
            };

            return View(userVM);
        }
        [HttpPost]
        public IActionResult EditUser(UserEditViewModel userVM)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("ErrorView");
            }

            var user = new User
            {
                ID = userVM.ID,
                FirstName = userVM.FirstName,
                LastName = userVM.LastName,
                Bithdaydate = userVM.Bithdaydate
            };
            _data.EditUser(user.ID, user);

            return View(user);
        }
        [HttpPost]
        private List<UsersRewards> InitUserRewardsList(int userID)
        {
            List<UsersRewards> userRewards = new List<UsersRewards>();
            foreach (var reward in _data.GetAllRewards())//передает всевозможные награды, которыми можно наградить пользователя
            {
                userRewards.Add(new UsersRewards { UserId = userID, RewardId = reward.ID, RewardTitle = reward.Title });
            }
            return userRewards;
        }
        [HttpPost]
        public IActionResult AchiveUser(int userID)
        {
            return View(InitUserRewardsList(userID));
        }
        [HttpPost]
        public IActionResult TakeRewardUser(int userID)
        {
            var userRewards = InitUserRewardsList(userID);

            return View(userRewards);
        }
        [HttpPost]
        public IActionResult UserRewardsDelete(int userID, int rewardID)
        {
            if (!ResultCompareUserReward(userID, rewardID) || !ResultCompareEsentialUsersReward(userID,rewardID)) return RedirectToAction("ErrorView");

            UsersRewards userRewards = new UsersRewards { UserId = userID, RewardId = rewardID };

            _data.TakeReward(userRewards);

            return RedirectToAction("Users");
        }

        [HttpPost]
        public IActionResult UserRewards(int userID, int rewardID)
        {
            if (!ResultCompareUserReward(userID, rewardID) || ResultCompareEsentialUsersReward(userID, rewardID))
                return RedirectToAction("ErrorView");

            var userReward = new UsersRewards { UserId = userID, RewardId = rewardID };

            _data.SetListUsersRewards(userReward);


            return RedirectToAction("Users");
        }


        private bool ResultCompareEsentialUsersReward(int userID, int rewardID)
        {
            bool resultOfCompare = false;

            foreach (var userRewards in _data.ShowAllRewardsOfUser(userID))
            {
                if (userRewards.RewardId == rewardID) resultOfCompare = true;
            }
            return resultOfCompare;

        }
        private bool ResultCompareUserReward(int userID, int rewardID)
        {
            var userRewardsInit = InitUserRewardsList(userID);
            bool resultOfCompare = false;
            foreach (var userRewardInit in userRewardsInit)
            {
                if (userRewardInit.RewardId == rewardID)
                {
                    resultOfCompare = true;
                }
            }
            return resultOfCompare;
        }


        [HttpPost]
        public IActionResult ShowAllUserRewards(int userID)
        {
            List<UsersRewards> userRewards = new List<UsersRewards>();

            foreach (var userReward in _data.ShowAllRewardsOfUser(userID))
            {
                userRewards.Add(
                    new UsersRewards
                    {
                        RewardId = userReward.RewardId,
                        UserId = userReward.UserId,
                        RewardTitle = _data.GetThisReward(userReward.RewardId).Title
                    });
            }

            return View(userRewards);
        }
        public IActionResult ErrorView()
        {
            return View();
        }
    }
}
