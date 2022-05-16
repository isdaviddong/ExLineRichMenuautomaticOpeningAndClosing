# ExLineRichMenuautomaticOpeningAndClosing
LINE在2022/5/13增加了postback的屬性，讓發人員可以藉由送出一個含有postbackAction的訊息(類似底下這樣)，來幫用戶來開啟(或關閉)rich menu，甚至可以開啟輸入鍵盤和語音: 

<img src=https://i.imgur.com/8yA9voy.png /> 

上圖 A 的部分，是一個 Buttons Template Message，其中有四個按鈕，都是我們先前介紹過的 postbackAction。

在過去當用戶點下postbackAction按鈕時，只是會讓伺服器端的WebHook收到一則訊息，但LINE 5/13增加了此功能之後，postbackAction多了兩個重要的屬性，分別是inputOption與fillInText。

inputOption可以是底下的值:
-   `closeRichMenu`: 關閉 rich menu
-   `openRichMenu`: 開啟 rich menu
-   `openKeyboard`: 開啟輸入鍵盤
-   `openVoice`: 開啟語音輸入

而 fillInText 則是當inputOption為openKeyboard時，開啟的輸入框的預設文字，例如，當建立 postbackAction 的程式碼如下:
```
Actions.Add(new  isRock.LineBot.PostbackAction() 
{
label  =  "開鍵盤",
data  =  "openKeyboard",
displayText  =  "開鍵盤",
fillInText  =  "預設文字",
inputOption  =  "openKeyboard"
});
```
則用戶點選該選單後，結果如下:

<img src=https://i.imgur.com/uRwGozt.png /> 

當建立 postbackAction 的程式碼如下:
```
Actions.Add(new  isRock.LineBot.PostbackAction() 
{
label  =  "開選單",
data  =  "openRichMenu",
displayText  =  "開選單",
inputOption  =  "openRichMenu"
});
```
則用戶點選該選單後，結果如下:

<img src=https://i.imgur.com/V0fIvDD.jpg /> 

你還可以透過底下指令，來開啟語音輸入:
```
Actions.Add(new  isRock.LineBot.PostbackAction() 
{
label  =  "開語音輸入",
data  =  "openVoice",
displayText  =  "開語音輸入",
inputOption  =  "openVoice"
});
```
<img src=https://i.imgur.com/eu381xJ.png /> 

很有趣吧，這功能可以讓你的LINE Bot與用戶的互動更加的便捷， .net core 的範例程式碼在底下:
https://github.com/isdaviddong/ExLineRichMenuautomaticOpeningAndClosing

你只需要將 LineBotSDK 升級到 2.5.33-beta 以上的版本即可。
