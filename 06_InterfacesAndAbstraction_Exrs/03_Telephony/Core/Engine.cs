using System.Runtime.CompilerServices;
using Telephony.Core.Interfaces;
using Telephony.Exceptions;
using Telephony.IO.Interfaces;
using Telephony.Models;
using Telephony.Models.Interfaces;

namespace Telephony.Core
{
    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;

        private readonly IStationaryPhone stationaryPhone;
        private readonly ISmartphone smartphone;

        

        public Engine()
        {
            this.stationaryPhone = new StationaryPhone();
            this.smartphone = new Smartphone();
        }
        public Engine(IReader reader, IWriter writer)
            :this()
        {
            this.reader = reader;
            this.writer = writer;
        }


        public void Run()
        {

            string[] phoneNumbers = this.reader.ReadLine().Split(" ");
            string[] urls = this.reader.ReadLine().Split(" ");

            foreach (var phoneNumber in phoneNumbers)
            {
                try
                {
                    if (phoneNumber.Length == 10)
                    {
                        this.writer.WriteLine(smartphone.Call(phoneNumber));
                    }
                    else if (phoneNumber.Length == 7)
                    {
                        this.writer.WriteLine(stationaryPhone.Call(phoneNumber));
                    }
                    else
                    {
                        throw new InvalidPhoneNumberException();
                    }
                }
                catch (InvalidPhoneNumberException ipne)
                {
                    this.writer.WriteLine(ipne.Message);
                }
                catch (Exception) { throw; }

            }
            foreach (var url in urls)
            {
                try
                {
                    this.writer.WriteLine(smartphone.BrowseURL(url));
                }
                catch(InvalidURLException iue)
                {
                    this.writer.WriteLine(iue.Message);
                }
                catch(Exception) { throw; }
            }
        }
    }
}
