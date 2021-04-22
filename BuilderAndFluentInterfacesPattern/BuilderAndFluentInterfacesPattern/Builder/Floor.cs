using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAndFluentInterfacesPattern.Builder
{
    public class Floor : IFloor
    {
        public int Lenght { get; set; }
        public int NumberOfTiles { get; set; }
        public string TypeGreatnessTiles { get; set; }

        public int ReturnLenght()
        {
            return Lenght;
        }
        public int ReturnNumberOfTiles()
        {
            return NumberOfTiles;
        }
        public string ReturnTypeGreatnessTiles()
        {
            return TypeGreatnessTiles;
        }

        public void SetLenght(int Lenght)
        {
            this.Lenght = Lenght;
        }
        public void SetNumberOfTiles(int NumberOfTiles)
        {
            this.NumberOfTiles = NumberOfTiles;
        }
        public void SetTypeGreatnessTiles(string TypeGreatnessTiles)
        {
            this.TypeGreatnessTiles = TypeGreatnessTiles;
        }
    }
}
