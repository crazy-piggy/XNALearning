using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace XNALearning
{
    /// <summary>
    /// 这是您游戏的主要类型
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch fpsWatcher;
        SpriteFont defaultFont;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// 允许游戏在开始运行之前执行它需要的任何初始化
        /// 这是它可以查询任何所需服务并加载任何非图形相关内容的地方
        /// 调用base.Initialize将枚举任何组件并初始化它们
        /// </summary>
        protected override void Initialize()
        {
            // TODO: 在这里添加您的初始化逻辑

            base.Initialize();
        }

        /// <summary>
        /// LoadContent将在每个游戏中调用一次，并且是加载所有内容的地方
        /// </summary>
        protected override void LoadContent()
        {
            // 创建一个新的SpriteBatch，它可以用来绘制纹理。
            fpsWatcher = new SpriteBatch(GraphicsDevice);
            defaultFont = Content.Load<SpriteFont>(@"Font/DefaultFont");

            // TODO: 用this.Content在这里加载您的游戏内容
        }

        /// <summary>
        /// UnloadContent将每个游戏调用一次，并且是卸载所有内容的地方
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: 在这里卸载任何非ContentManager内容
        }

        /// <summary>
        /// 允许游戏运行逻辑，如更新世界，检查碰撞，收集输入和播放音频
        /// </summary>
        /// <param name="gameTime">提供定时值的快照</param>
        protected override void Update(GameTime gameTime)
        {
            // TODO: 在这里添加您的更新逻辑
            fpsWatcher.Begin();
            fpsWatcher.End();
            base.Update(gameTime);
        }

        /// <summary>
        /// 当游戏应该自行绘制时调用此方法
        /// </summary>
        /// <param name="gameTime">提供计时值的快照</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            fpsWatcher.Begin();
            fpsWatcher.DrawString(defaultFont, $"FPS: ", Vector2.Zero, Color.Black);
            fpsWatcher.End();
            // TODO: 在这里添加您的绘图代码

            base.Draw(gameTime);
        }
    }
}
