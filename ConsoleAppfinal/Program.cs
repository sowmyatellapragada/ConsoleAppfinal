using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.Clients;
using Twilio.Jwt.AccessToken;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace ConsoleAppfinal
{
    class Program
    {
        static void Main(string[] args)
        {
            //Send an SMS using twilio  with c#
            string accountSid = "ACacf0616dc165865b7d289d46e7fff56e";
            string authToken = "96973f9fea2dc57f8ad78e5ee954ec57";

            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
           body: "Join Earth's mightiest heroes. Like Kevin Bacon.",
               from: new Twilio.Types.PhoneNumber("+15017122661"),
               to: new Twilio.Types.PhoneNumber("+15558675310")
           );

            Console.WriteLine(message.Sid);

            //Send an voice message using twilio  with c#
            string accountSid = "ACacf0616dc165865b7d289d46e7fff56e";
            string authToken = "96973f9fea2dc57f8ad78e5ee954ec57";

            TwilioClient.Init(accountSid, authToken);

            var to = new PhoneNumber("+916301134751");
            var from = new PhoneNumber("+15076930654");
            var call = CallResource.Create(to, from,
                url: new Uri("http://demo.twilio.com/docs/voice.xml")
        );

            Console.WriteLine(call.Sid);


            // Send notification to guest using twilio with c# 
            const accountSid = "ACacf0616dc165865b7d289d46e7fff56e";
            const authToken = "96973f9fea2dc57f8ad78e5ee954ec57";
            const client = require('twilio')(accountSid, authToken);

            const notificationOpts = {
              identity: '00000001', // We recommend using a GUID or other anonymized identifier for Identity.
              body: 'Knok-Knok! This is your first Notify SMS',
               };

           client.notify.services('IS8b7d2c750bb74fb8aaa86182f129e0e0').notifications.create(notificationOpts).then(notification => console.log(notification.sid)).catch(error => console.log(error));

            //Send a message with image URL
             string accountSid = "ACacf0616dc165865b7d289d46e7fff56e";
             string authToken = "96973f9fea2dc57f8ad78e5ee954ec57";

             TwilioClient.Init(accountSid, authToken);

             var mediaUrl = new[] {new Uri("https://c1.staticflickr.com/3/2899/14341091933_1e92e62d12_b.jpg")}.ToList();
             var message = MessageResource.Create(
             body: "This is the ship that made the Kessel Run in fourteen parsecs?",
             from: new Twilio.Types.PhoneNumber("+15076930654"),
             mediaUrl: mediaUrl,
             to: new Twilio.Types.PhoneNumber("+916301134751")
  );

             Console.WriteLine(message.Sid); 

            //Make Outbound Phone Calls with C# 
            string accountSid = "ACacf0616dc165865b7d289d46e7fff56e";
            string authToken = "96973f9fea2dc57f8ad78e5ee954ec57";

            TwilioClient.Init(accountSid, authToken);
                 var call = CallResource.Create(
                url: new Uri("http://demo.twilio.com/docs/classic.mp3"),
                to: new Twilio.Types.PhoneNumber("+916301134751"),
                from: new Twilio.Types.PhoneNumber("+15076930654")
            );

            Console.WriteLine(call.Sid);
        }
    }
}
