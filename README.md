# NBusy Chat Bot
NBusy chat bot for generating automated responses to incoming messages via NBusy SDK.

## What can it be used for?
As NBusy API is not publicly accessible yet, this cat bot cannot be used to connect to the NBusy services yet. Instead, it can be utilized as a sample for building an [AIML](http://en.wikipedia.org/wiki/AIML) based chat bot. There is a bundled console application so you can compile and t the chat bot immediately.

## Documentation
See the [documentation](https://github.com/NBusy/NBusy.ChatBot/wiki)

## Sample Usage
You can simply compile and run the bundled console application to start chatting with the bot. You can also use the `ChatBot` class to get a response for an input as a string.

```csharp
var chatBot = new ChatBot("ConsoleUser");

while (true)
{
	Console.Write("You: ");
	var input = Console.ReadLine();
	if (string.IsNullOrEmpty(input) || input.ToLower() == "close")
	{
		break;
	}

	var response = chatBot.Chat(input);
	Console.WriteLine("Bot: " + response);
}
```

## Changelog
See the [release notes](https://github.com/NBusy/NBusy.ChatBot/blob/master/ReleaseNotes.md)
	
## LICENSE
[GNU LGPL](https://github.com/NBusy/NBusy.ChatBot/blob/master/License.md)

Note: A.L.I.C.E. AIML sets (*.aiml files) included in this project are licensed separately under GNU GPL.

## Acknowledgements
[A.L.I.C.E. AIML](http://www.alicebot.org/aiml.html) sets included in this project are licensed under the GNU GPL and are based on the original work by [Dr. Richard S. Wallace](http://www.alicebot.org/bios/richardwallace.html).

C# implementation of AIML interpreter, the AIMLbot, is based on the original work by [Nicholas H.Tollervey](http://ntoll.org/) and is licensed under GNU LGPL.
