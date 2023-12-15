using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_time_Pokemon
{
    internal class pokeshop
    {
        public string _ShopName { get; set; }
        public List<items> ItemsInPokeshop { get; set; }

        public pokeshop(string shopname)
        {
            _ShopName = shopname;
            ItemsInPokeshop = new List<items>();
        }

        public void ShopItems(pokemontrener trener)
        {
            Console.WriteLine("Velkommen til PokeShop.");
            Console.WriteLine("Vi har følgende produkter:");
            for (int i = 0; i < ItemsInPokeshop.Count; i++)
            {
                Console.WriteLine(i + ". " + ItemsInPokeshop[i]._ItemType);
            }

            Console.Write("Hva vil du ha?");
            int input = Console.ReadKey().KeyChar;
            trener.BuyItem(ItemsInPokeshop[input]);

        }
    }

}

