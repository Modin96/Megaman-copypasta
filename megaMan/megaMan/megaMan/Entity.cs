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
        protected bool isAlive = true, isJumping = false;
        protected float velocity = 0;

        public float speedY, speedX;


       public Entity(Texture2D texture, Vector2 position)
       :base(texture,position)
       {
           this.speedX = 5f;
           this.speedY = 13f;
       }

       public virtual void Update(GameWindow window)
       {
           if (isJumping)
           {
               velocity += 0.5f;
               if (velocity >= speedY) 
               { 
                   velocity = speedY;
                   isJumping = false;
               }

               position.Y += velocity;
 
           }
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
           position.X += speedX;
       }

       public void MoveLeft() // minskar x värdet (åker vänster)
       {
           position.X -= speedX;
       }

       public void MoveUp() // ökar y värdet (åker upp)
       {
           position.Y -= speedY;
       }

       public void MoveDown() // minskar y värdet (åker ner)
       {
           position.Y += speedY;

       }

       public void jump() // ökar y värdet (åker upp)
       {
           if (!isJumping)
           {
               isJumping = true;
               velocity = -speedY;
           }
       }


   





       
    }
}
