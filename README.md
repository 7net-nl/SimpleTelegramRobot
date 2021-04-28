# SimpleTelegramRobot
This is simple Telegram robot, Method for command, query and text

If you want use this, you should Enable webhook in robot telegram.

HomeController for Webhook and Testcontroller for test robot in local or debug.

You should change token in startup.cs 

services.AddSingleton<ITelegramBotClient>(c => new TelegramBotClient("111111111:1111111111111111111111"));


