using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.v1
{
    class InterfaceSegregation
    {
        //-------wrong approach-------

        interface IToy
        {
            void setPrice(int price);
            void setColor(String color);
            void move();
            void fly();
        }

        class ToyHouse : IToy
        {
            int price;
            String color;

            public void setPrice(int price)
            {
                this.price = price;
            }

            public void setColor(String color)
            {
                this.color = color;
            }

            public void move()
            {
                throw new Exception("Not allowed");
            }

            public void fly()
            {
                throw new Exception("Not allowed");

            }
        }

        //-------correct approach------

        interface IToyOK
        {
            void setPrice(int price);
            void setColor(String color);
        }

        interface IMovableOK
        {
            void move();
        }

        interface IFlyableOK
        {
            void fly();
        }

        class ToyHouseOK : IToyOK
        {
            int price;
            String color;

            public void setPrice(int price)
            {

                this.price = price;
            }

            public void setColor(String color)
            {
                this.color = color;
            }
        }

        class ToyPlane : IToyOK, IMovableOK, IFlyableOK
        {
            double price;
            String color;

            public void setPrice(int price)
            {
                this.price = price;
            }

            public void setColor(String color)
            {
                this.color = color;
            }

            public void move()
            {
                //code related to moving plane
            }

            public void fly()
            {
                // code related to flying plane
            }
        }
    }
}
