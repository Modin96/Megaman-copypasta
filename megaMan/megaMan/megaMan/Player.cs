﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace megaMan
{
    public class Player : Entity
    {
        public Player(Texture2D texture, Vector2 position)
            : base(texture, position)
        {

        }

        public override void Update(GameWindow window)
        {

            KeyboardState newState = Keyboard.GetState(); // kontroller

            if (newState.IsKeyDown(Keys.W))
            {
                jump();
            }
            

            if (newState.IsKeyDown(Keys.A))
            {
                MoveLeft();
            }

            if (newState.IsKeyDown(Keys.D))

            {
                MoveRight();
            }

            base.Update(window);
        }



    }
}
