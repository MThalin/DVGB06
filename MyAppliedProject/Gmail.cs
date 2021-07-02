using AE.Net.Mail;
using System;

namespace MyAppliedProject
{
    class Gmail
    {
        Controller co;
        static ImapClient ic;
        private string from1, from2, from3;
        private string subject1, subject2, subject3;
        private string body1, body2, body3;

        public Gmail(Controller coIn)
        {
            co = coIn;
        }

        private void Login(string user, string pass)
        {
            ic = new ImapClient("imap.gmail.com", user, pass, AuthMethods.Login, 993, true);
        }

        private void GetEmails()
        {
            ic.SelectMailbox("INBOX");

            var email1 = ic.GetMessage(ic.GetMessageCount() - 1);
            from1 = email1.From.ToString();
            subject1 = email1.Subject;
            body1 = email1.Body;

            var email2 = ic.GetMessage(ic.GetMessageCount() - 2);
            from2 = email2.From.ToString();
            subject2 = email2.Subject;
            body2 = email2.Body;

            var email3 = ic.GetMessage(ic.GetMessageCount() - 3);
            from3 = email3.From.ToString();
            subject3 = email3.Subject;
            body3 = email3.Body;
        }

        public void SetEmails(string user, string pass)
        {
            try
            {
                Login(user, pass);
                GetEmails();
                co.GmailReAction(from1, from2, from3, subject1, subject2, subject3, body1, body2, body3);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

    }
}
