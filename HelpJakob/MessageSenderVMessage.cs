namespace HelpJakob
{
    public class MessageSenderVMessage
    {
        private HTMLConverter convert;
        
        public void Send(MessageCarrier type, MessageMng m, bool isHTML)
        {
            if (type.Equals(MessageCarrier.VMessage))
            {
                if (isHTML)
                    m.Body = convert.ConvertBodyToHTML(m.Body);
                //her implementeres alt koden til at sende via VMessage
            }
        }

        public void Send(MessageCarrier type, string[] to, MessageMng m, bool isHTML)
        {
            if (type.Equals(MessageCarrier.VMessage))
            {
                if (isHTML)
                    m.Body = convert.ConvertBodyToHTML(m.Body);
                //her implementeres alt koden til at sende via VMessage
            }
        }
    }
}