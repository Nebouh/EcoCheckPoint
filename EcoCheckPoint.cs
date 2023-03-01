using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Utils;
using System;

namespace Eco.Mods.CheckPoint
{
	[ChatCommandHandler]
	public class EcoCheckPointCommands
	{
		[ChatCommand("Lists of check points commands", "cp", ChatAuthorizationLevel.Admin)] public static void CheckPoint(User user) { }

		[ChatSubCommand("CheckPoint", "Permit the player to save a location", "save", ChatAuthorizationLevel.Admin)]
		public static void Wand(User user)
		{
			Log.WriteError(Localizer.Do($"Save location"));
		}
		
		[ChatSubCommand("CheckPoint", "Permit the player to tp to last saved location", "tp", ChatAuthorizationLevel.Admin)]
		public static void Wand(User user)
		{
			Log.WriteError(Localizer.Do($"tp location"));
		}
	}
}