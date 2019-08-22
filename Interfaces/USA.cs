using System;
namespace Interfaces
{
    public class USA : IPostcode
    {
        public bool IsValid(string postcode)
        {
            if (postcode.Length < 5)
            {
                return true;
            }
            else
            {
                return false;
            }
          
            
        }

        public string Region(string postcode)
        {
            return postcode;
        }
    }

}
