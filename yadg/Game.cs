using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using YADG.Entities;

namespace YADG;

public class Game : Microsoft.Xna.Framework.Game
{
    private const string ASSET_NAME_SPRITESHEET = "YADGSpritesheet";
    private const string ASSET_NAME_SFX_HIT = "hit";
    private const string ASSET_NAME_SFX_SCORE_REACHED = "score-reached";
    private const string ASSET_NAME_SFX_BTN_PRESS = "button-press";

    public const int WINDOW_WIDTH = 600, WINDOW_HEIGHT = 150;

    public const int TREX_START_POS_Y = WINDOW_HEIGHT - 16;

    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;

    private SoundEffect _sfxHit;
    private SoundEffect _sfxBtnPress;
    private SoundEffect _sfxScoreReached;

    private Texture2D _spriteSheetTexture;

    private Trex _trex;

    public Game()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        base.Initialize();
        _graphics.PreferredBackBufferHeight = WINDOW_HEIGHT;
        _graphics.PreferredBackBufferWidth = WINDOW_WIDTH;
        _graphics.ApplyChanges();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);

        _spriteSheetTexture = Content.Load<Texture2D>(ASSET_NAME_SPRITESHEET);

        _sfxHit = Content.Load<SoundEffect>(ASSET_NAME_SFX_HIT);
        _sfxBtnPress = Content.Load<SoundEffect>(ASSET_NAME_SFX_BTN_PRESS);
        _sfxScoreReached = Content.Load<SoundEffect>(ASSET_NAME_SFX_SCORE_REACHED);

        _trex = new Trex(_spriteSheetTexture, new Vector2(20, 20));
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        // TODO: Add your update logic here

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.White);

        _spriteBatch.Begin();

        _trex.Draw(_spriteBatch, gameTime);

        _spriteBatch.End();

        base.Draw(gameTime);
    }
}
