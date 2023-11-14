using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace YADG.Entities
{
    public interface IGameEntity
    {
        int DrawOrder { get; }

        void Update(GameTime gameTime);

        void Draw(SpriteBatch spriteBatch, GameTime gameTime);
    }
}
