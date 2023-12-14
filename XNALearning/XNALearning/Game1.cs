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
    /// ��������Ϸ����Ҫ����
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
        /// ������Ϸ�ڿ�ʼ����֮ǰִ������Ҫ���κγ�ʼ��
        /// ���������Բ�ѯ�κ�������񲢼����κη�ͼ��������ݵĵط�
        /// ����base.Initialize��ö���κ��������ʼ������
        /// </summary>
        protected override void Initialize()
        {
            // TODO: ������������ĳ�ʼ���߼�

            base.Initialize();
        }

        /// <summary>
        /// LoadContent����ÿ����Ϸ�е���һ�Σ������Ǽ����������ݵĵط�
        /// </summary>
        protected override void LoadContent()
        {
            // ����һ���µ�SpriteBatch��������������������
            fpsWatcher = new SpriteBatch(GraphicsDevice);
            defaultFont = Content.Load<SpriteFont>(@"Font/DefaultFont");

            // TODO: ��this.Content���������������Ϸ����
        }

        /// <summary>
        /// UnloadContent��ÿ����Ϸ����һ�Σ�������ж���������ݵĵط�
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: ������ж���κη�ContentManager����
        }

        /// <summary>
        /// ������Ϸ�����߼�����������磬�����ײ���ռ�����Ͳ�����Ƶ
        /// </summary>
        /// <param name="gameTime">�ṩ��ʱֵ�Ŀ���</param>
        protected override void Update(GameTime gameTime)
        {
            // TODO: ������������ĸ����߼�
            fpsWatcher.Begin();
            fpsWatcher.End();
            base.Update(gameTime);
        }

        /// <summary>
        /// ����ϷӦ�����л���ʱ���ô˷���
        /// </summary>
        /// <param name="gameTime">�ṩ��ʱֵ�Ŀ���</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            fpsWatcher.Begin();
            fpsWatcher.DrawString(defaultFont, $"FPS: ", Vector2.Zero, Color.Black);
            fpsWatcher.End();
            // TODO: ������������Ļ�ͼ����

            base.Draw(gameTime);
        }
    }
}
