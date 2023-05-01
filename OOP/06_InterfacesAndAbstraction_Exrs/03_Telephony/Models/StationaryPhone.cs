using Telephony.Exceptions;
using Telephony.Models.Interfaces;

namespace Telephony.Models
{
    public class StationaryPhone : IStationaryPhone
    {
        public StationaryPhone() { }
        public string Call(string phoneNumber)
        {
            if(!ValidatePhoneNumber(phoneNumber))
            {
                throw new InvalidPhoneNumberException();
            }

            return $"Dialing... {phoneNumber}";
        }
        private bool ValidatePhoneNumber(string phoneNumber)
            => phoneNumber.All(ch => char.IsDigit(ch)); // the number is valid if all simbols are digits
    }
}
