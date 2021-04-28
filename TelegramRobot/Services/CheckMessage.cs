using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace TelegramRobot.Services
{
    public class CheckMessage : ICheckMessage
    {

        public bool Text(Chat chat , Message message)
        {
                 if (message.From.IsBot)
                {
                 
                }

                if (message.Type == MessageType.ChatMembersAdded || message.Type == MessageType.ChatMemberLeft )
                {
                

                }

               
             

            return true;


        }




        public bool Command(Chat chat, Message message)
        {



            if (message.Text.ToLower() == "/start")
            {
                
            }



            return true;

        }



        public bool CallBack(CallbackQuery callbackQuery)
        {
            return true;
        }

        public bool MessageOrCommand(Chat chat, Message message)
        {
            return message.Type == MessageType.Text ? Command(chat, message) ? true : Text(chat, message) : Text(chat, message);
        }


    }
}
