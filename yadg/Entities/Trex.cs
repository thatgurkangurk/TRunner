using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using YADG.Graphics;

namespace YADG.Entities
{
    public class Trex : IGameEntity
    {
        private const int IDLE_SPRITE_POS_X = 40, IDLE_SPRITE_POS_Y = 0;

        public const int DEFAULT_SPRITE_POS_X = 848,
            DEFAULT_SPRITE_POS_Y = 0,
            DEFAULT_SPRITE_WIDTH = 44,
            DEFAULT_SPRITE_HEIGHT = 52;

        private Sprite _idleSprite;

        public Sprite Sprite { get; private set; }

        public TrexState State { get; private set; }

        public Vector2 Position { get; set; }

        public bool IsAlive { get; private set; }

        public float Speed { get; private set; }

        public int DrawOrder { get; set; }

        public Trex(Texture2D spriteSheet, Vector2 pos)
        {
            Sprite = new Sprite(spriteSheet,
                DEFAULT_SPRITE_POS_X,
                DEFAULT_SPRITE_POS_Y,
                DEFAULT_SPRITE_WIDTH,
                DEFAULT_SPRITE_HEIGHT
            );
            Position = pos;
            _idleSprite = new Sprite(spriteSheet, IDLE_SPRITE_POS_X, IDLE_SPRITE_POS_Y, DEFAULT_SPRITE_WIDTH, DEFAULT_SPRITE_HEIGHT);
            State = TrexState.Idle;
        }

        public void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            if (State == TrexState.Idle)
            {
                _idleSprite.Draw(spriteBatch, Position);
            }
            Sprite.Draw(spriteBatch, Position);
        }

        public void Update(GameTime gameTime)
        {
            
        }
    }
}
