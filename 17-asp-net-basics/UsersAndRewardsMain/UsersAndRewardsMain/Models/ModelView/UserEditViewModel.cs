using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UsersAndRewardsMain.Models.ModelView
{
    public class UserEditViewModel
    {
        [Required]
        public int ID { get; set; }
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        [Required]
        public DateTime Bithdaydate { get; set; }
        public int Age
        {
            get
            {
                var differentDates = DateTime.Now.Year - Bithdaydate.Year;

                return (DateTime.Now.Month < Bithdaydate.Month) ? differentDates - 1 : differentDates;
            }
            private set
            {
            }
        }
    }
}
