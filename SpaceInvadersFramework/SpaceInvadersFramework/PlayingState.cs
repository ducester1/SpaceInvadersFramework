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
        GameObjectList invaders;
        public PlayingState()
        {
            player = new Player();
            var xPos = SpaceInvaders.Screen.X / 2 - player.Width / 2;
            var yPos = SpaceInvaders.Screen.Y - player.Width;
            player.Position = new Vector2(xPos, yPos);
            Add(player);

            invaders = new GameObjectList();

            Add(invaders);
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    var asset = "blue_invader";
                    if (j == 1) asset = "yellow_invader";
                    if (j == 2) asset = "red_invader";
                    invaders.Add(new Invader(asset));
                    {
                        position = new Vector2(i * 50, j * 50);
                    }
                }
            }
        }

    }
}
