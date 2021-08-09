using AE.Net.Mail;

namespace MyAppliedProject
{
    class Mail
    {
        Controller co;
        static ImapClient ic;
        private string from1, from2;
        private string subject1, subject2;
        private string body1, body2;

        public Mail(Controller coIn)
        {
            co = coIn;
        }

        public void Login(string mail, string user, string pass)
        {
            switch (mail)
            {
                case "gmail":
                    ic = new ImapClient("imap.gmail.com", user, pass, AuthMethods.Login, 993, true);
                    break;

                case "outlook":
                    ic = new ImapClient("outlook.office365.com", user, pass, AuthMethods.Login, 993, true);
                    break;

                default:
                    break;
            }
        }

        public void Logout()
        {
            ic = null;
        }

        public void GetEmails()
        {
            ic.SelectMailbox("INBOX");

            var email1 = ic.GetMessage(ic.GetMessageCount() - 1);
            from1 = email1.From.ToString();
            subject1 = email1.Subject;
            body1 = email1.Body.Trim();

            var email2 = ic.GetMessage(ic.GetMessageCount() - 2);
            from2 = email2.From.ToString();
            subject2 = email2.Subject;
            body2 = email2.Body.Trim();

            co.MailReAction(from1, from2, subject1, subject2, body1, body2);
        }
    }
}
