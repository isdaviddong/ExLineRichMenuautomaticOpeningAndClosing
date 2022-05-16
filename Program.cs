using System;
using System.Collections.Generic;

namespace ExLineRichMenuautomaticOpeningAndClosing
{
    class Program
    {
        static void Main(string[] args)
        {
            var ChannelAccessToken = "___token___"; //Channel Access Token
            var UserId = "___UserID____"; //收訊者
            var bot = new isRock.LineBot.Bot(ChannelAccessToken);

            //建立Actions
            var Actions = new List<isRock.LineBot.TemplateActionBase>();

            Actions.Add(new isRock.LineBot.PostbackAction() //UriAction
            {
                label = "開選單",
                data = "openRichMenu",
                displayText = "開選單",
                inputOption = "openRichMenu"
            });
            Actions.Add(new isRock.LineBot.PostbackAction() //UriAction
            {
                label = "關選單",
                data = "closeRichMenu",
                displayText = "關選單",
                inputOption = "closeRichMenu"
            });
            Actions.Add(new isRock.LineBot.PostbackAction() //UriAction
            {
                label = "開鍵盤",
                data = "openKeyboard",
                displayText = "開鍵盤",
                fillInText = "預設文字",
                inputOption = "openKeyboard"
            });
            Actions.Add(new isRock.LineBot.PostbackAction() //UriAction
            {
                label = "開語音輸入",
                data = "openVoice",
                displayText = "開語音輸入",
                inputOption = "openVoice"
            });
            //建立發送訊息
            isRock.LineBot.ButtonsTemplate btnMsg =
            new isRock.LineBot.ButtonsTemplate()
            {
                thumbnailImageUrl = new Uri("https://i.imgur.com/5JKErL4.png"),
                text = "請按底下選項",
                title = "測試自動開關選單",
                actions = Actions,
            };
            //發送訊息
            bot.PushMessage(UserId, btnMsg);
        }
    }
}
