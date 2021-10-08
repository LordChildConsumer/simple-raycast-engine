using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGame.Extended;


namespace RaycastEngine.GameData
{
    public class World
    {
        // General Variables
        public static int mapX = 8, mapY = 8, mapS = 64;

        public static int[] map =
        {
            1, 1, 1, 1, 1, 1, 1, 1,
            1, 0, 1, 0, 0, 0, 0, 1,
            1, 0, 1, 0, 0, 0, 0, 1,
            1, 0, 0, 0, 0, 0, 0, 1,
            1, 0, 0, 0, 0, 0, 0, 1,
            1, 0, 3, 0, 0, 1, 0, 1,
            1, 0, 0, 0, 0, 0, 0, 1,
            1, 1, 1, 1, 1, 1, 1, 1,
        };

        static int wallType = 0;
        static Color wallColor = new Color(0f, 0f, 0f, 0f);


        public static void drawMap2D(SpriteBatch _spriteBatch)
        {
            int x, y;
            for (y = 0; y < mapY; y++)
            {
                for (x = 0; x < mapX; x++)
                {
                    _spriteBatch.Begin();
                    if (map[y * mapX + x] > 0) { wallType = map[y * mapX + x]; } else { wallType = 0; }

                    switch (wallType)
                    {
                        case 1:     // Red
                            wallColor = new Color(0.9f, 0f, 0f, 1f);
                            break;
                        case 2:     // Green
                            wallColor = new Color(0f, 0.9f, 0f, 1f);
                            break;
                        case 3:     // Blue
                            wallColor = new Color(0f, 0f, 0.9f, 1f);
                            break;
                        default:    // Black
                            wallColor = new Color(0.0f, 0f, 0f, 1f);
                            break;
                    }


                    ShapeExtensions.FillRectangle(_spriteBatch, new Vector2(x, y) * mapS, new Size2(mapS - 1, mapS - 1), wallColor, 0);
                    _spriteBatch.End();
                }
            }
        }
    }
}
