using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAndFluentInterfacesPattern.Builder
{
    public interface IFloor
    {
        int Lenght { get; set; }
        int NumberOfTiles { get; set; }
        string TypeGreatnessTiles { get; set; }

        int ReturnLenght();
        int ReturnNumberOfTiles();
        string ReturnTypeGreatnessTiles();

        void SetLenght(int Lenght);
        void SetNumberOfTiles(int NumberOfTiles);
        void SetTypeGreatnessTiles(string TypeGreatnessTiles);
    }
}
