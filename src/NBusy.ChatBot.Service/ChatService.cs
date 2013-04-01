// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ChatService.cs" company="NBusy">
//   Copyright (c) Teoman Soygul. All rights reserved. See License.md in the project root for license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace NBusy.ChatBot.Service
{
	using System.ServiceProcess;

	public partial class ChatService : ServiceBase
	{
		public ChatService()
		{
			this.InitializeComponent();
		}

		protected override void OnStart(string[] args)
		{
		}

		protected override void OnStop()
		{
		}
	}
}