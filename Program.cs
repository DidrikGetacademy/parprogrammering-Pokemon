namespace PP_time_Pokemon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var shop = new pokeshop("Olivanders");
            shop.ItemsInPokeshop.Add(new items("pokeball"));
            shop.ItemsInPokeshop.Add(new items("healthpotion"));

            var trener = new pokemontrener("Ash");
            trener._Pokemons.Add(new pokemon("Pikachu", 100, 20, true));


            bool gaming = true;

            while (gaming)
            {
                Console.WriteLine("meny");
                Console.WriteLine("1. inventory");
                Console.WriteLine("2. pokeshop");
                Console.WriteLine("3. exit program");
                var input = Console.ReadKey().KeyChar; 
                Console.WriteLine();
                switch (input)
                {
                    case '1':
                       trener.ViewInventory();
                        break;


                    case '2':
                        shop.ShopItems(trener);
                       
                        break;

                    case '3':
                  
                        gaming = false;
                        break;

                    default:
                        Console.WriteLine("ugyldig kommando");
                        break;
                }
            }


        }
    }
}

/*
 Appen du skal lage må ha en pokemontrener. Brukeren skal få velge navn og startpokemon.
Treneren skal ha mulighet til å gå i forskjellig terreng (grass, vann) der vilkårlige pokemen kan dukke opp. 
Man kan fange eller kjempe mot de ville pokemenna som dukker opp (det kan hende de også stikker av).
Treneren kan også gå inn i pokeshop for å skaffe seg flere pokeballer eller health potions som kan brukes i combat.
Man skal ha mulighet til å se hvilke pokemen treneren har, og også annen inventory som pokeballer/potions.
 
- pokemontrener
    - Name
    - capture
    - realease
    - iteminventory
    - pokedex
- pokemons
    - type (grass/water)
    - name
    - damage
    - health
    - fight
    - flight
- items
    - pokeball
    - health potion
    - energy potion
- pokeshop
    - selger forskjellige items
 */