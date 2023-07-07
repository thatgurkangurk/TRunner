﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace TRunner;

public class TRunnerGame : Game
{
    private const string ASSET_NAME_SPRITESHEET = "TRunnerSpritesheet";
    private const string ASSET_NAME_SFX_HIT = "hit";
    private const string ASSET_NAME_SFX_SCORE_REACHED = "score-reached";
    private const string ASSET_NAME_SFX_BTN_PRESS = "button-press";

    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;

    private SoundEffect _sfxHit;
    private SoundEffect _sfxBtnPress;
    private SoundEffect _sfxScoreReached;

    private Texture2D _spriteSheetTexture;

    public TRunnerGame()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here

        base.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);

        _spriteSheetTexture = Content.Load<Texture2D>(ASSET_NAME_SPRITESHEET);

        _sfxHit = Content.Load<SoundEffect>(ASSET_NAME_SFX_HIT);
        _sfxBtnPress = Content.Load<SoundEffect>(ASSET_NAME_SFX_BTN_PRESS);
        _sfxScoreReached = Content.Load<SoundEffect>(ASSET_NAME_SFX_SCORE_REACHED);
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
        GraphicsDevice.Clear(Color.CornflowerBlue);

        _spriteBatch.Begin();

        _spriteBatch.Draw(_spriteSheetTexture, new Vector2(10, 10), new Rectangle(848, 0, 44, 52), Color.White);

        _spriteBatch.End();

        base.Draw(gameTime);
    }
}
