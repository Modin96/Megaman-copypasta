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
       public float speed;

       public Sprite(Texture2D texture, Vector2 position)
       {
           this.texture = texture;
           this.position = position;
           this.speed = 4.5f;
       }
   
       public void Draw(SpriteBatch spriteBatch)
       {
           Vector2 tmp;
           tmp.X = position.X;
           tmp.Y = position.Y;
           spriteBatch.Draw(texture,tmp, Color.White);
       }


       public void MoveRight() // ökar x värdet (åker höger)
       {
           position.X -= speed;
       }

       public void MoveLeft() // minskar x värdet (åker vänster)
       {
           position.X += speed;
       }

       public void MoveUp() // ökar y värdet (åker upp)
       {
           position.Y -= speed;
       }

       public void MoveDown() // minskar y värdet (åker ner)
       {
           position.Y += speed;
       }




       public bool DetectCollision(Rectangle otherRect) // kod för kollision
        {
            Rectangle myRect = new Rectangle(Convert.ToInt32(position.X), Convert.ToInt32(position.Y), texture.Width, texture.Height * length);
            
            if (myRect.Intersects(otherRect))
            {
                return true;
            }
            return false;
        }
    }
}

       

