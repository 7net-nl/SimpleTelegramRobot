using Telegram.Bot.Types;

namespace TelegramRobot.Services
{
    public interface ICheckMessage
    {
       
        bool Text(Chat chat, Message message);
        bool Command(Chat chat, Message message);
        bool CallBack(CallbackQuery callbackQuery);
        bool MessageOrCommand(Chat chat, Message message);


    }
}