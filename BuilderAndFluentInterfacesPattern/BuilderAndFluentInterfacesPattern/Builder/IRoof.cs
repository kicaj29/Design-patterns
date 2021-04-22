using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAndFluentInterfacesPattern.Builder
{
    public interface IRoof
    {
        int Height { get; set; }

        int ReturnHeight();

        void SetHeight(int Height);
    }
}
