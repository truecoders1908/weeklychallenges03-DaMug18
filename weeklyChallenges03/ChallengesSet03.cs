using System;
using System.Collections.Generic;
using System.Linq;



namespace WeeklyChallenges03
{

    public class ChallengesSet03
    {
            public bool ArrayContainsAFalse(bool[] vals)
            {
                foreach (bool x in vals)
                {
                if (x == false)
                    return true;

                }
            return false;
            }
            
            public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
            {
            if (numbers == null)
                return false;
            int x = numbers.Sum();
            if (x % 2 == 0)
                return false;
            else
                return true;
            }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            if (password.Any(char.IsUpper)&& password.Any(char.IsLower) && password.Any(char.IsDigit))
            {
                return true;
            }

            return false;
        }
            public char GetFirstLetterOfString(string val)
            {
            return val[0];
            }

            public char GetLastLetterOfString(string val)
            {
            return val.Last();
            
            }

            public decimal Divide(decimal dividend, decimal divisor)
            {
            if (divisor == 0)
                return 0;
            return dividend / divisor;
            }

            public int LastMinusFirst(int[] nums)
            {

            int x = nums.Last() - nums[0];
            return x;
            }

            public int[] GetOddsBelow100()
            {
                throw new NotImplementedException();
            }

            public void ChangeAllElementsToUppercase(string[] words)
            {
                throw new NotImplementedException();
            }

    }
}
