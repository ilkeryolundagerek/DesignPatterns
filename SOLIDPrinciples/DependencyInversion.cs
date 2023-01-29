using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples
{
    internal class DependencyInversion
    {
    }

    //Bad way...
    public class SMSBad
    {
        public void SendSMS()
        {
            //...
        }
    }

    public class EMailBad
    {
        public void SendEMail()
        {
            //...
        }
    }

    public class WhistleBad
    {
        public void SendCall()
        {
            //...
        }
    }

    public class MessageCenterBad
    {
        private SMSBad sms = new SMSBad();
        private EMailBad email = new EMailBad();
        private WhistleBad whistle = new WhistleBad();

        public void SendMessages()
        {
            sms.SendSMS();
            email.SendEMail();
            whistle.SendCall();
        }
    }

    //Good way...

    public interface IMessengerGood
    {
        void SendMessage();
    }

    public class SMSGood : IMessengerGood
    {
        public void SendMessage()
        {
            sendSMS();
        }

        private void sendSMS() { }
    }

    public class EMailGood : IMessengerGood
    {
        public void SendMessage()
        {
            sendEmail();
        }

        private void sendEmail() { }
    }

    public class WhistleGood : IMessengerGood
    {
        public void SendMessage()
        {
            sendCall();
        }

        private void sendCall() { }
    }

    public class MessageCenterGood
    {
        private List<IMessengerGood> messengers;

        public MessageCenterGood(List<IMessengerGood> messengers)
        {
            this.messengers = messengers;
        }

        public void SendMessages()
        {
            foreach (var messenger in messengers)
            {
                messenger.SendMessage();
            }
        }
    }

}
