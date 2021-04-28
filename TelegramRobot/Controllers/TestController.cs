using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using TelegramRobot.Services;

namespace TelegramRobot.Controllers
{
    public class TestController : Controller
    {
        private readonly ITelegramBotClient client;
        private readonly ICheckMessage checkMessage;
       
        public byte LoopTime = 0;
        public TestController(ITelegramBotClient client, ICheckMessage checkMessage)
        {
            this.client = client;
            this.checkMessage = checkMessage;
          
        }



        public IActionResult Index(string Test = "")
        {
            //client.DeleteWebhookAsync();
            //client.StartReceiving();
            //client.OnUpdate += GetUpdate;

            return Ok("true");

        }

        private void GetAllMessage(object sender, MessageEventArgs c)
        {
            checkMessage.MessageOrCommand(c.Message.Chat, c.Message);
        }

      
        private void GetUpdate(object sender, UpdateEventArgs e)
        {


          CheckType(e.Update, UpdateType.CallbackQuery, c => checkMessage.CallBack(c.CallbackQuery));

           CheckType(e.Update, UpdateType.Message, c => checkMessage.MessageOrCommand(c.Message.Chat, c.Message));


        }

        private void CheckType(Update update, UpdateType updateType, Func<Update, bool> func)
        {
            if (update.Type == updateType) func(update);
        }













    }















}
