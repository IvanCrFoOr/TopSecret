using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel1
{
    public class Messages
    {
        public string[] GetMessages(string[] messages)
        {
            string[] arrayMessage = new string[] { "este", "es", "un", "mensaje", "secreto" };
            string[] newListMessages = new string[messages.Length];

            for (int k = 0; k < messages.Length; k++)
            {
                try
                {
                    if (messages.Contains(arrayMessage[k]))
                    {
                        newListMessages[k] = messages[k];
                    }
                    else
                    {
                        newListMessages[k] = string.Empty;
                    }
                }
                catch 
                {
                    newListMessages[k] = string.Empty;
                    continue;
                }
                
            }


            return newListMessages;
        }
    }
}
