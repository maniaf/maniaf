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
using Image = SixLabors.ImageSharp.Image;
using SixLabors.ImageSharp;
using System.Runtime.InteropServices;

namespace maniaf
{
    internal class maniafgame : GameWindow
    {
        public maniafgame()
            : base(GameWindowSettings.Default, NativeWindowSettings.Default)
        {
            this.CenterWindow(new Vector2i(1600, 900));
            Image<Rgba32> image = (Image<Rgba32>)Image.Load(Configuration.Default, "../../../assets/maniaf225.png");
            image.TryGetSinglePixelSpan(out var span);
            byte[] pixels = MemoryMarshal.AsBytes(span).ToArray();
            this.Icon = new OpenTK.Windowing.Common.Input.WindowIcon(new OpenTK.Windowing.Common.Input.Image(225, 225, pixels));
        }

        protected override void OnUpdateFrame(FrameEventArgs args)
        {
            base.OnUpdateFrame(args);
        }

        protected override void OnRenderFrame(FrameEventArgs args)
        {
            GL.ClearColor(new Color4(0f, 0f, 0f, 1f));
            GL.Clear(ClearBufferMask.ColorBufferBit);

            this.Context.SwapBuffers();
            base.OnRenderFrame(args);
        }
    }
}
