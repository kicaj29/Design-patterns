using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAndFluentInterfacesPattern.Builder
{
    public class Wall : IWall
    {
        public int Thickness { get; set; }
        public string Color { get; set; }

        public int ReturnThickness()
        {
            return Thickness;
        }

        public string ReturnColor()
        {
            return Color;
        }

        public void SetThickness(int Thickness)
        {
            this.Thickness = Thickness;
        }

        public void SetColor(string Color)
        {
            this.Color = Color;
        }
    }
}
