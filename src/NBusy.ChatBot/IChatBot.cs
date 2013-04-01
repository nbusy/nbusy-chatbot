// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IChatBot.cs" company="NBusy">
//   Copyright (c) Teoman Soygul. All rights reserved. See License.md in the project root for license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace NBusy.ChatBot
{
	public interface IChatBot
	{
		/// <summary>
		/// Provides an response to the given input.
		/// </summary>
		/// <param name="input">The input to the conversation.</param>
		/// <returns>A response based on the configured AIML files and provided settings.</returns>
		string Chat(string input);
	}
}