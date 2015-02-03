using System;
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
    public class Sprite
    {
        public Texture2D texture;
        public Vector2 position;



       public Sprite(Texture2D texture, Vector2 position)
       {
           this.texture = texture;
           this.position = position;

           
       }
        
        public bool DetectCollision(Rectangle otherRect) // kod för kollision

        {
            Rectangle myRect = new Rectangle(Convert.ToInt32(position.X), Convert.ToInt32(position.Y), texture.Width, texture.Height );
            
            if (myRect.Intersects(otherRect))
            {
                return true;
            }
            return false;
            // scruee git hub


        }

    }
}
