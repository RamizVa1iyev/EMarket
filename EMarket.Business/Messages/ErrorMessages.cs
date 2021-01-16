using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMarket.Business.Messages
{
    public static class ErrorMessages
    {
        public static string GreaterThanZeroMessage = "Your input must be greater than 0";
        public static string GreaterThanOrEqualToZeroMessage = "Your input must be greater than or equal to 0";
        public static string NullProductMessage = "Please select the product...";
        public static string LengthMessage(int min, int max)
        {
            return String.Format($"Your input must be between {min} and {max} character");
        }  
        public static string ExclusiveBetween(int min , int max)
        {
            return String.Format($"Your input must be between {min} and {max}");
        }
    }
}
