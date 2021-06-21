﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using PixelDefense.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelDefense.Gameplay
{
    public class Base:AnimationManager
    {
        public int health;
        public Game1 game;

        public Base(Animation animation, Game1 game):base(animation)
        {
            _animation = animation;
            _animationManager = new AnimationManager(animation);
            health = 10000;
            Position = new Vector2(30, 780);
            _animationManager.Scale = 2.2f;
            this.game = game;
        }

        public override void Update(GameTime gameTime)
        {
            

            if (GetBaseHealth() <= 10000 && GetBaseHealth() >= 8800)
            {
                _animationManager._animation.CurrentFrame = 0;
            }
            else if (GetBaseHealth() < 8800 && GetBaseHealth() >= 7600)
            {
                _animationManager._animation.CurrentFrame = 1;
            }
            else if (GetBaseHealth() < 7600 && GetBaseHealth() >= 6400)
            {
                _animationManager._animation.CurrentFrame = 2;
            }
            else if (GetBaseHealth() < 6400 && GetBaseHealth() >= 5200)
            {
                _animationManager._animation.CurrentFrame = 3;
            }
            else if (GetBaseHealth() < 5200 && GetBaseHealth() >= 4000)
            {
                _animationManager._animation.CurrentFrame = 4;
            }
            else if (GetBaseHealth() < 4000 && GetBaseHealth() >= 2800)
            {
                _animationManager._animation.CurrentFrame = 5;
            }
            else if (GetBaseHealth() < 2800 && GetBaseHealth() > 1600)
            {
                _animationManager._animation.CurrentFrame = 6;
            }
            else if (GetBaseHealth() < 1600 && GetBaseHealth() > 0)
            {
                _animationManager._animation.CurrentFrame = 7;
            }
            else if (GetBaseHealth() <= 0)
            {
                game.ChangeState(game.gameOverState);
                
            }
        }

        protected override void SetAnimations()
        {
            
                _animationManager.Play(_animation);
            
            
                _animationManager.UpdateBoundingBox();
        }


        public override void Draw(SpriteBatch spriteBatch)
        {
            if (_animationManager != null)
            {
                _animationManager.Draw(spriteBatch);
            }
            
        }
        public void SetBaseHealth(int health)
        {
            this.health = health;
        }

        public int GetBaseHealth()
        {
            return this.health;
        }
    }
}