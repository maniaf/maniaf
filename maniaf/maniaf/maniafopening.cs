using OpenTK.Graphics.OpenGL;
using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maniaf.scene
{
    internal class maniafopening
    {
        public void Start()
        {
            GL.ClearColor(new Color4(0.1f, 0.1f, 0.1f, 1f));
            GL.Clear(ClearBufferMask.ColorBufferBit);
        }
    }
}
