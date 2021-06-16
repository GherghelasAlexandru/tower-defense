﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using PixelDefense.Controls;
using PixelDefense.Gameplay;
namespace PixelDefense.States
{
    public class SettingsState : State
    {
        private List<Button> _button;
        public SettingsState(Game1 game, GraphicsDevice graphicsDevice, ContentManager content)
         : base(game, graphicsDevice, content)
        {
            var buttonTexture = _content.Load<Texture2D>("Controls/button3");
            var font = _content.Load<SpriteFont>("Fonts/Font");



            var chooseBackButton = new Button(buttonTexture, font)
            {
                Position = new Vector2(550, 450),
                Text = "Back",
            };

            chooseBackButton.Click += BackButton_Click;

            _button = new List<Button>()
            {
                chooseBackButton,
            };
<<<<<<< Updated upstream
=======

            //XDocument xml = XDocument.Load("C:\\Users\\User\\AppData\\Roaming\\PixelDefense\\XML\\Settings.xml");
                            //Globals.save.GetFile("XML\\Settings.xml"); throws null exception?????
            
        }

        public virtual void LoadSaveFile(XDocument saveData)
        {
            if(saveData != null)
            {
                List<string> allSettings = new List<string>();
                for (int i = 0; i < arrowSelector.Count; i++)
                {
                    allSettings.Add(arrowSelector[i].title);
                }

                for (int i = 0; i < allSettings.Count; i++)
                {
                    List<XElement> optionList = (from t in saveData.Element("Root").Element("Settings").Descendants("setting")
                                                 where t.Element("name").Value == allSettings[i]
                                                 select t).ToList<XElement>();

                    if (optionList.Count > 0)
                    {
                        for (int j = 0; j < arrowSelector.Count; j++)
                        {
                            if (arrowSelector[j].title == allSettings[i])
                            {
                                arrowSelector[j].selected = Convert.ToInt32(optionList[0].Element("selected").Value);
                            }
                        }
                    }
                }

            }
>>>>>>> Stashed changes
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            _game.ChangeState(_game.menuState);
        }
        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            foreach (var button in _button)
                button.Draw(gameTime, spriteBatch);
        }

        public override void PostUpdate(GameTime gameTime)
        {
            // remove sprites if they're not needed
        }

        public override void Update(GameTime gameTime)
        {
            foreach (var button in _button)
                button.Update(gameTime);
        }
    }
}
