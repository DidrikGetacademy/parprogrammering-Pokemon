using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_time_Pokemon
{
    internal class pokemontrener
    {
        public string _Name { get; set; }

        public List<pokemon> _Pokemons { get; set; }
        public List<items> _Items { get; set; }

        public int _pokeballs { get; set; }

        public int _healthPotions { get; set; }

        public pokemontrener(string name)
        {
            _Name = name;
            _Pokemons = new List<pokemon>();
            _Items = new List<items>();
            _pokeballs = 0;
            _healthPotions = 0;
        }

        void CatchPokemon()
        {

        }

        void ReleasePokemon()
        {

        }

       public void ViewInventory()
        {
           

            Console.WriteLine($"antall: pokeballs: {_pokeballs}");
            Console.WriteLine($"antall: healthPotions: {_healthPotions}");

     
        }

       public void Pokedex()
        {
            Console.WriteLine("pokemons");
            foreach (pokemon pokemon in _Pokemons)
            {
                Console.WriteLine($"Pokemon: {pokemon._Name}  Health: {pokemon._Health}, Damage: {pokemon._Damage}");
            }
        }

        void usePotion()
        {

        }
       public void usePokeball()
        {
            Console.WriteLine("du kastet en pokeball");
            _pokeballs--;
            var usedpokeball = _Items.FindAll(item => item._ItemType == "pokeball");
            _pokeballs = usedpokeball.Count;          
        }

       public void BuyItem(items item)
        {
            
            _Items.Add(item);
            if (item._ItemType == "pokeball")
            {
                _pokeballs++;
                Console.WriteLine($"du har kjøpt {item._ItemType}, antall pokeballs: {_pokeballs}");
            }else if (item._ItemType == "healthpotion")
            {
                _healthPotions++;
                Console.WriteLine($"du har kjøpt {item._ItemType}, antall HealthPotions: {_healthPotions}");
            }
        }

        /*
         * - pokemontrener
    - Name
    - capture
    - realease
    - iteminventory
    - pokedex
         */
    }
}
