// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="NBusy">
//   Copyright (c) Teoman Soygul. All rights reserved. See License.md in the project root for license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace NBusy.ChatBot.Service
{
	using System;
	using System.ServiceProcess;

	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		private static void Main()
		{
			// This application will run as a console app if it is compiled so. If it is compiled as a Windows app,
			// it will be a Windows service (hence non-interactive)
			if (Environment.UserInteractive)
			{
				var chatBot = new ChatBot("ConsoleUser");

				while (true)
				{
					Console.Write("You: ");
					var input = Console.ReadLine();
					if (string.IsNullOrEmpty(input) || input.ToLower() == "exit" || input.ToLower() == "quit" || input.ToLower() == "close")
					{
						break;
					}

					var response = chatBot.Chat(input);
					Console.WriteLine("Bot: " + response);
				}
			}
			else
			{
				var servicesToRun = new ServiceBase[] { new ChatService() };
				ServiceBase.Run(servicesToRun);
			}
		}
	}
}