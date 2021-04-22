using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAndFluentInterfacesPattern.Builder
{
    public class Roof : IRoof
    {
        public int Height { get; set; }

        public int ReturnHeight()
        {
            return Height;
        }

        public void SetHeight(int Height)
        {
            this.Height = Height;
        }
    }
}
