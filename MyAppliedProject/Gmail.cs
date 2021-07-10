using AE.Net.Mail;
using System;

namespace MyAppliedProject
{
    class Gmail
    {
        Controller co;
        static ImapClient ic;
        private string from1, from2;
        private string subject1, subject2;
        private string body1, body2;

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
        }

        public void SetEmails(string user, string pass)
        {
            try
            {
                Login(user, pass);
                GetEmails();
                co.GmailReAction(from1, from2, subject1, subject2, body1, body2);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

    }
}
