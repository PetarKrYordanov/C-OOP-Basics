using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator
{
   public class Validator
    {
        public static void CheckRating(int rating, string skillName)
        {
            if (rating<0 || rating>100)
            {
                throw new ArgumentException($"{skillName} sould be betweem 0 and 100.");
            }
        }

        public static void ValidateName (string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("A name should not be empty.");
            }
        }
    }
}
