﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using YADG.Graphics;

namespace YADG.Entities
{
    public class Trex : IGameEntity
    {
        private const int TREX_DEFAULT_SPRITE_POS_X = 848,
            TREX_DEFAULT_SPRITE_POS_Y = 0,
            TREX_DEFAULT_SPRITE_WIDTH = 44,
            TREX_DEFAULT_SPRITE_HEIGHT = 52;

        public Sprite Sprite { get; private set; }

        public TrexState State { get; private set; }

        public Vector2 Position { get; set; }

        public bool IsAlive { get; private set; }

        public float Speed { get; private set; }

        public int DrawOrder { get; set; }

        public Trex(Texture2D spriteSheet, Vector2 pos)
        {
            Sprite = new Sprite(spriteSheet,
                TREX_DEFAULT_SPRITE_POS_X,
                TREX_DEFAULT_SPRITE_POS_Y,
                TREX_DEFAULT_SPRITE_WIDTH,
                TREX_DEFAULT_SPRITE_HEIGHT
            );
            Position = pos;
        }

        public void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            Sprite.Draw(spriteBatch, Position);
        }

        public void Update(GameTime gameTime)
        {
            
        }
    }
}
