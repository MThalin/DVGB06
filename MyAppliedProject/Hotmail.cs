using System;
using AE.Net.Mail;

namespace MyAppliedProject
{
    class Hotmail
    {
        Controller co;
        static ImapClient pc;
        private string from1, from2;
        private string subject1, subject2;
        private string body1, body2;

        public Hotmail(Controller coIn)
        {
            co = coIn;

        }
        private void Login(string user, string pass)
        {
            pc = new ImapClient("outlook.office365.com", user, pass, AuthMethods.Login, 993, true);
        }

        private void GetEmails()
        {
            pc.SelectMailbox("INBOX");
            var email1 = pc.GetMessage(pc.GetMessageCount() - 1);
            from1 = email1.From.ToString();
            subject1 = email1.Subject;
            body1 = email1.Body;

            var email2 = pc.GetMessage(pc.GetMessageCount() - 2);
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
                co.MailFail();
            }
        }

    }
}
