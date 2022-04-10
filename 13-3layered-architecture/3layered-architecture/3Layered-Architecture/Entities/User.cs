using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Entities
{
    public class User
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
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
        public string UserRewards { get; set; }

    }
}
