﻿using System;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;

namespace ProjectBot2.Dialogs
{
    [LuisModel("8a4fdce8-e29d-4acd-9c3e-eb2918b6558b", "1477d4114445442fb6ec1021ca89f5ec")]
    [Serializable]
    public class MoodDialog : LuisDialog<object>
    {
	   [LuisIntent("Main Menu")]
	   public async Task MainMenu(IDialogContext context, LuisResult result)
	   {
		  await context.PostAsync("You want to return to the main menu");
		  context.Wait(MessageReceived);
	   }

	   [LuisIntent("Step Back")]
	   public async Task StepBack(IDialogContext context, LuisResult result)
	   {
		  await context.PostAsync("You want to return to the last question");
		  context.Wait(MessageReceived);
	   }

	   [LuisIntent("Restart Tree")]
	   public async Task RestartTree(IDialogContext context, LuisResult result)
	   {
		  await context.PostAsync("You want to restart the diagnostic test");
		  context.Wait(MessageReceived);
	   }

	   [LuisIntent("ConfirmSelection")]
	   public async Task ConfirmSelection(IDialogContext context, LuisResult result)
	   {
		  await context.PostAsync("You want to confirm/say yes");
		  context.Wait(MessageReceived);
	   }

	   [LuisIntent("DenySelection")]
	   public async Task DenySelection(IDialogContext context, LuisResult result)
	   {
		  await context.PostAsync("You want to cancel/say no");
		  context.Wait(MessageReceived);
	   }
    }
}