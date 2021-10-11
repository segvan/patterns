using System;

namespace patterns.library.Bridge
{
    public interface IRenderer
    {
        void RenderCircle(float radius);
    }
    
    public class VectorRenderer : IRenderer
    {
        public void RenderCircle(float radius)
        {
            Console.WriteLine("Vector circle rendering");
        }
    }
    
    public class RasterRenderer : IRenderer
    {
        public void RenderCircle(float radius)
        {
            
            Console.WriteLine("Raster circle rendering.");
        }
    }

    public abstract class Shape
    {
        protected readonly IRenderer renderer;

        public Shape(IRenderer renderer)
        {
            this.renderer = renderer;
        }

        public abstract void Renderer();
    }
    
    // Instead of adding methods to the circle of drawing it
    public class Circle: Shape
    {
        private readonly float radius;

        public Circle(float radius, IRenderer renderer) : base(renderer)
        {
            this.radius = radius;
        }

        public override void Renderer()
        {
            renderer.RenderCircle(radius);
        }
    }
}