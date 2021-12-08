namespace HelpJakob
{
    public class MessageSenderVMessage
    {
        private HTMLConverter convert;
        
        //This couldt be removed, it would be posible for SendToAll() to take care of this
        public void Send(MessageCarrier type, MessageMng m, bool isHTML)
        {
            if (type.Equals(MessageCarrier.VMessage))
            {
                if (isHTML)
                    m.Body = convert.ConvertBodyToHTML(m.Body);
                //her implementeres alt koden til at sende via VMessage
            }
        }

        
        // The array can hold one to more people and there for the methode Send could be redundant
        public void SendToAll(MessageCarrier type, string[] to, MessageMng m, bool isHTML)
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