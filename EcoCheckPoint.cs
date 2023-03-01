using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using Eco.Shared.Utils;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;
using System.Numerics;

namespace Eco.Mods.CheckPoint
{
    [ChatCommandHandler]
    public class EcoCheckPointCommands
    {
        public static Position position;
        [ChatCommand("Lists of check points commands", "cp", ChatAuthorizationLevel.User)] public static void CheckPoint(User user) { }

        [ChatSubCommand("CheckPoint", "Permit the player to save a location", "cps", ChatAuthorizationLevel.User)]
        public static void CheckPointSave(User user)
        {
            Log.WriteError(Localizer.Do($"Save"));
            position = Position.create("Test", user.Position);
        }

        [ChatSubCommand("CheckPoint", "Permit the player to tp to last saved location", "cph", ChatAuthorizationLevel.User)]
        public static void CheckPointHome(User user)
        {
            Log.WriteError(Localizer.Do($"tp"));
            user.Player.SetPosition(position.Localization);
        }
    }

    public class Position
    {
        public string Name{ get; private set; }
        public Vector3 Localization { get; private set; }

        public static Position create(string positionName, System.Numerics.Vector3 localization)
        {
            Position position = new Position();
            position.Name = positionName;
            position.Localization = localization;
            return position;
        }
    }
}