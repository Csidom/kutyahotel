using System;
using System.Collections.Generic;
using System.Text;

namespace kutyahotel.Models
{
    public class Cat : Pet
    {
        public Cat(string name) : base(name, "Macska", "🐈")
        {
        }

        public override string Speak()
        {
            return "Cica hangeffekt";
        }

        public override string Play()
        {
            ChangeStats(-15, 20, -10);
            return $"{Name} egy döglött madárfiókával játszott!";
        }
    }
}
