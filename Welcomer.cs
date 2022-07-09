using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using UnityEngine;
using Oxide.Game.Rust.Libraries;
using Oxide.Core.Libraries.Covalence;
using Oxide.Core.Plugins;


namespace Oxide.Plugins
{
    [Info("Welcomer", "Phoenix", "1.0.0")]
    [Description("Sends welcome/goodbye message when joining server")]
    public class Welcomer : CovalencePlugin
    {
        #region void
        void Init()
        {
            Puts("Loaded Welcomer successfully!");
        }

        #endregion

        #region OnPlayerConnect&OnPlayerDisconnected
        void OnPlayerConnected(BasePlayer player)
        {
            server.Broadcast($"<color=#5891ed>{player.displayName}</color> has washed ashore!");
            Puts($"{player.displayName} has connected!");
        }


        /*
            Called after the player has disconnected from the server
            No return behavior
        */
        void OnPlayerDisconnected(BasePlayer player, string reason)
        {
            server.Broadcast($"<color=#5891ed>{player.displayName}</color> has been lost at sea!");
            Puts($"{player.displayName} has disconnected!({reason})");
        }
        #endregion
    }
}