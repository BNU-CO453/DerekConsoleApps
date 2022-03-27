using SkiaSharp;

namespace ConsoleAppProject.App05
{
    public class Game
    {
        public Game()
        {
            SKImageInfo imageInfo = new SKImageInfo(400, 300);
            using (SKSurface surface = SKSurface.Create(imageInfo))
            {
                SKCanvas canvas = surface.Canvas;
                canvas.Clear(SKColors.Red);
            }
        }

        public void Run()
        {

        }
    }
}
