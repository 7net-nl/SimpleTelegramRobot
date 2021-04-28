using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using TelegramRobot.Services;


namespace TelegramRobot.Controllers
{
 
    public class HomeController : Controller
    {
        private readonly ITelegramBotClient client;
        private readonly ICheckMessage checkMessage;
       

        public HomeController(ITelegramBotClient client,ICheckMessage checkMessage)
        {
            this.client = client;
            this.checkMessage = checkMessage;
         
        }


        
        public IActionResult Index([FromBody]Update update)
        {


            CheckType(update, UpdateType.CallbackQuery, c => checkMessage.CallBack(c.CallbackQuery));

            CheckType(update, UpdateType.Message, c => checkMessage.MessageOrCommand(c.Message.Chat, c.Message));

            return Ok("true");

        }

        

        private void CheckType(Update update, UpdateType updateType, Func<Update, bool> func)
        {
            if (update.Type == updateType) func(update);
        }

    }

    

       











}
