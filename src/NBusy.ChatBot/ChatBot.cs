// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ChatBot.cs" company="NBusy">
//   Copyright (c) Teoman Soygul. All rights reserved. See License.md in the project root for license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace NBusy.ChatBot
{
	using AIMLbot;

	public class ChatBot : IChatBot
	{
		private readonly Bot bot;

		private readonly User user;

		public ChatBot(string userId)
		{
			this.bot = new Bot();
			this.bot.loadSettings();

			this.user = new User(userId, this.bot);
			this.bot.isAcceptingUserInput = false;
			this.bot.loadAIMLFromFiles();
			this.bot.isAcceptingUserInput = true;
		}

		public string Chat(string input)
		{
			var request = new Request(input, this.user, this.bot);
			var response = this.bot.Chat(request);

			return response.Output;
		}
	}
}