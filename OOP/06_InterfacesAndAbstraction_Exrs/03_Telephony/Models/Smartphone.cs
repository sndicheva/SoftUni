using Telephony.Exceptions;
using Telephony.Models.Interfaces;

namespace Telephony.Models
{
    public class Smartphone : ISmartphone
    {
        public Smartphone() { }
        public string Call(string phoneNumber)
        {
            if (!ValidatePhoneNumber(phoneNumber))
            {
                throw new InvalidPhoneNumberException();
            }

            return $"Calling... {phoneNumber}";
        }
        public string BrowseURL(string url)
        {
            if (!ValidateURL(url))
            {
                throw new InvalidURLException();
            }

            return $"Browsing: {url}!";
        }

        private bool ValidatePhoneNumber(string phoneNumber)
            => phoneNumber.All(ch => char.IsDigit(ch)); // the number is valid if all simbols are digits

        private bool ValidateURL(string url)
            => url.All(ch => !char.IsDigit(ch));
    }
}
