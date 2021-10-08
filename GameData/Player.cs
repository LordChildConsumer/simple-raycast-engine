using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using MonoGame.Extended;

namespace RaycastEngine.GameData
{
    public class Player
    {
        // Movement Variables
        public static float px, py;
        public static float MoveSpeed = 0.5f;

        // Rotation Variables
        public static float pdx, pdy, pa;

        public static float RotationSpeed = 0.05f;

        public static void DrawPlayer(SpriteBatch spriteBatch)
        {
            ShapeExtensions.DrawPoint(spriteBatch, new Vector2(px, py), Color.Yellow, 8, 0); // Draw the Player Point
            ShapeExtensions.DrawLine(spriteBatch, new Vector2(px, py), new Vector2(px + pdx * 5, py + pdy * 5), Color.Yellow, 2.5f, 1f);
        }
    }
}
