using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_time_Pokemon
{
    internal class pokemon
    {
       public string _Name {  get; set; }
       
       public int _Health { get; set; }
       public int _Damage { get; set; }
       public bool _Grasspokemon { get; set; }


        // List<pokemon> _GrassPokemon;
        //  List<pokemon> _WaterPokemon;

        public pokemon(string name, int health, int damage, bool grasspokemon)
        {
            _Name = name;
            _Health = health;
            _Damage = damage;
            _Grasspokemon = grasspokemon;   
        }
     


        public void Fight() { }

        public void Escape() { }

        public void Attack() { }



    }
}
/*- pokemons
   - type (grass/water)
   - name
   - damage
   - health
   - fight
   - flight*/