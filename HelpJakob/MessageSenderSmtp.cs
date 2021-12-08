namespace HelpJakob
{
    public class MessageSenderSmtp
    {
        private HTMLConverter convert;

        public void Send(MessageCarrier type, MessageMng m, bool isHTML)
        {
            //herinde sendes der en email ud til modtageren
            if (type.Equals(MessageCarrier.Smtp))
            {
                if (isHTML)
                    m.Body = convert.ConvertBodyToHTML(m.Body);
                //her implementeres alt koden til at sende via Smtp
            }
        }
        public void SendToAll(MessageCarrier type, string[] to, MessageMng m, bool isHTML)
        {
            if (type.Equals(MessageCarrier.Smtp))
            {
                if (isHTML)
                    m.Body = convert.ConvertBodyToHTML(m.Body);
                //her implementeres alt koden til at sende via Smtp
            }
        }
    }
}