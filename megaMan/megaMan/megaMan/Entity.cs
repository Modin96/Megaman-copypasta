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
    public class Entity : Sprite
    {
        protected bool isAlive = true;

        public float speed;

       public Entity(Texture2D texture, Vector2 position)
       :base(texture,position)
       {
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
           position.X += speed;
       }

       public void MoveLeft() // minskar x värdet (åker vänster)
       {
           position.X -= speed;
       }

       public void MoveUp() // ökar y värdet (åker upp)
       {
           position.Y -= speed;
       }

       public void MoveDown() // minskar y värdet (åker ner)
       {
           position.Y += speed;
       }
    }
}
