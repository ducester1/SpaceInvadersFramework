using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceInvadersFramework
{
    class Player : SpriteGameObject
    {
        public Player()
            :base("ship")
        {
        }

        public override void HandleInput(InputHelper inputHelper)
        {
            base.HandleInput(inputHelper);
            velocity.X = 0;
            if (inputHelper.IsKeyDown(Keys.Left))
            {
                velocity.X = -500;
            }
            else if (inputHelper.IsKeyDown(Keys.Right))
            {
                velocity.X = 500;
            }

        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            position = Vector2.Clamp(position, Vector2.Zero, new Vector2(SpaceInvaders.Screen.X - Width, SpaceInvaders.Screen.Y));
            //Console.WriteLine(position);
            //if (position.X <= 0)
            //{
            //    position.X = 0;
            //    velocity.X = 0;
            //} else if (position.X >= SpaceInvaders.Screen.X - )
            //{
            //    position.X = SpaceInvaders.Screen.X;
            //    velocity.X = 0;
            //}
        }
    }
}
