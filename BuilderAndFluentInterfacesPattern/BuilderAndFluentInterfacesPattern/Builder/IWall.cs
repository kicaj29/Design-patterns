using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAndFluentInterfacesPattern.Builder
{
    public interface IWall
    {
        int Thickness { get; set; }
        string Color { get; set; }

        int ReturnThickness();
        string ReturnColor();

        void SetThickness(int Thickness);
        void SetColor(string Color);
    }
}
