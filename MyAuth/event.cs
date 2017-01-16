﻿using MiNET;
using MiNET.Net;
using MiNET.Plugins;
using MiNET.Plugins.Attributes;
using MiNET.Worlds;

namespace MyAuth
{
    public class events : Plugin
    {

        protected override void OnEnable()
        {
            Class1._log.Info("Event Handler");
        }

        [PacketHandler]
        public Package onChat(McpeText packet, Player player)
        {
            if (!Class1.lged.ContainsKey(player.Username.ToLower()))
            {
                notlogin(player);
                return null;
            }
            return packet;
        }

        [PacketHandler]
        public Package onUseItem(McpeUseItem packet, Player player)
        {
            if (!Class1.lged.ContainsKey(player.Username.ToLower()))
            {
                notlogin(player);
                return null;
            }
            return packet;
        }

        [PacketHandler]
        public Package onInteract(McpeInteract packet, Player player)
        {
            if (!Class1.lged.ContainsKey(player.Username.ToLower()))
            {
                notlogin(player);
                return null;
            }
            return packet;
        }

        [PacketHandler]
        public Package onDropItem(McpeDropItem packet, Player player)
        {
            if (!Class1.lged.ContainsKey(player.Username.ToLower()))
            {
                notlogin(player);
                return null;
            }
            return packet;
        }

        [PacketHandler]
        public Package onCraftingEvent(McpeCraftingEvent packet, Player player)
        {
            if (!Class1.lged.ContainsKey(player.Username.ToLower()))
            {
                notlogin(player);
                return null;
            }
            return packet;
        }


        [PacketHandler]
        public Package onMovePlayer(McpeMovePlayer packet, Player player)
        {
            if (!Class1.lged.ContainsKey(player.Username.ToLower()))
            {
                notlogin(player);
                return null;
            }
            return packet;
        }


        [PacketHandler]
        public Package onMobArmorEquipment(McpeMobArmorEquipment packet, Player player)
        {
            if (!Class1.lged.ContainsKey(player.Username.ToLower()))
            {
                notlogin(player);
                return null;
            }
            return packet;
        }

        [PacketHandler]
        public Package onCommandStep(McpeCommandStep packet, Player player)
        {
            if (!Class1.lged.ContainsKey(player.Username.ToLower()))
            {
                if (!packet.commandName.Equals("register") || packet.commandName.Equals("login"))
                {
                    notlogin(player);
                }
                return null;
            }
            return packet;
        }


        public void OnBreak(object o, BlockBreakEventArgs e)
        {
            if (!Class1.lged.ContainsKey(e.Player.Username.ToLower()))
            {
                notlogin(e.Player);
                e.Cancel = true;
            }
        }


        public void OnPlace(object o, BlockPlaceEventArgs e)
        {
            if (!Class1.lged.ContainsKey(e.Player.Username.ToLower()))
            {
                notlogin(e.Player);
                e.Cancel = true;
            }
        }

        public void notlogin(Player player)
        {
            player.SendMessage("Please Login", MessageType.Popup);
        }



        /////まだまだ追加するよ！
    }
}
