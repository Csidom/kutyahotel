using System;
using System.Collections.Generic;
using System.Text;

namespace kutyahotel.Models
{
    public class Dog : Pet
    {
        public Dog(string name) : base(name, "Kutya", "🐩")
        {
        }

        public override string Speak()
        {
            return "Ugatás hangeffekt";
        }

        public override string Play()
        {
            ChangeStats(-14, 30, -24);
            return $"{Name} játszott egy jót a labdájával!";
        }
    }
}
