using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace SpaceInvadersFramework
{
    class PlayingState : GameObjectList
    {
        Player player;
        public PlayingState()
        {
            player = new Player();
            var xPos = SpaceInvaders.Screen.X / 2 - player.Width / 2;
            var yPos = SpaceInvaders.Screen.Y - player.Width;
            player.Position = new Vector2(xPos, yPos);
            Add(player);

        }

    }
}
