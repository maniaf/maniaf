using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Windowing.Desktop;
using OpenTK.Windowing.Common;
using OpenTK.Graphics.OpenGL;
using OpenTK.Mathematics;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp;
using System.Runtime.InteropServices;

namespace maniaf
{
    internal class maniafgame : GameWindow
    {
        public maniafgame()
            : base(GameWindowSettings.Default, NativeWindowSettings.Default)
        {
            this.Title = "ManiaF";
            this.WindowBorder = WindowBorder.Hidden;
            Image<Rgba32> image = (Image<Rgba32>)Image.Load(Configuration.Default, "../../../assets/maniaf.png");
            image.TryGetSinglePixelSpan(out var span);
            byte[] pixels = MemoryMarshal.AsBytes(span).ToArray();
            this.Icon = new OpenTK.Windowing.Common.Input.WindowIcon(new OpenTK.Windowing.Common.Input.Image(3000, 3000, pixels));
            // this.WindowState = WindowState.Fullscreen;
            this.CenterWindow(new Vector2i(1600, 900));
        }
        protected override void OnResize(ResizeEventArgs e)
        {
            Console.WriteLine($"{e.Width}/{e.Height}");
            GL.Viewport(0,0,e.Width,e.Height);
            base.OnResize(e);
        }
        protected override void OnLoad()
        {
            base.OnLoad();
        }
        protected override void OnUnload()
        {
            base.OnUnload();
        }

        protected override void OnUpdateFrame(FrameEventArgs args)
        {
            base.OnUpdateFrame(args);
        }

        protected override void OnRenderFrame(FrameEventArgs args)
        {
            GL.ClearColor(new Color4(0.1f, 0.1f, 0.1f, 1f));
            GL.Clear(ClearBufferMask.ColorBufferBit);

            this.Context.SwapBuffers();
            base.OnRenderFrame(args);
        }
    }
}
