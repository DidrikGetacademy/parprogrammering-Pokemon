using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_time_Pokemon
{
    internal class Pokemonverden
    {

        public List<pokemon> Pokelist = new List<pokemon>()
        {
            new pokemon("Raichu", 100, 20, true),
            new pokemon("Squirtle", 100, 20, true),
            new pokemon("Bulbasaur", 100, 20, true),
            new pokemon("Rattata", 100, 20, true),
            new pokemon("Dragonite", 100, 20, true),
            new pokemon("Gengar", 100, 20, true),
            new pokemon("Jigglypuff", 100, 20, true),
            new pokemon("Mewtwo", 100, 20, true),
            new pokemon("Charizard", 120, 25, false),
            new pokemon("Giratina", 110, 22, false),
            new pokemon("Alakazam", 90, 18, false),
            new pokemon("Gyarados", 130, 28, false),
            new pokemon("Machamp", 95, 23, false),
            new pokemon("regigigas", 80, 21, false),
        };
    }
}
