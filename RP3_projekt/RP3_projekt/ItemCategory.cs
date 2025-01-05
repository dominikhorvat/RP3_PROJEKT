using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP3_projekt
{
    internal enum ItemCategory
    {
        WATER,
        SPARKLING_WATER,
        JUICE,
        FRESH_JUICE,
        FIZZY_DRINK,
        COFFEE,
        BEER,
        WINE,
        LIQUEUR,
        HARD_LIQUOR,
        HOT_CHOCOLATE,
        TEA,
        ENERGY_DRINK,
        COCKTAIL,
        OTHER
    }

    /// <summary>
    /// Pomoćna klasa koja služi kako bi se kategorije artikala na korisničkom sučelu prikazale na hrvatskom.
    /// </summary>
    static class ItemCategoryUtility
    {
        /// <summary>
        /// Mapa čiji je kluč enumeracija kategorije artikla, a vrijednost prijevod na hrvatski.
        /// </summary>
        public static readonly Dictionary<ItemCategory, string> itemCategoryTranslations = new Dictionary<ItemCategory, string>
        {
            { ItemCategory.WATER, "voda"},
            { ItemCategory.SPARKLING_WATER, "gazirana voda"},
            { ItemCategory.JUICE, "sok"},
            { ItemCategory.FRESH_JUICE, "cijeđeni sok"},
            { ItemCategory.FIZZY_DRINK, "gazirano piće"},
            { ItemCategory.COFFEE, "kava"},
            { ItemCategory.BEER, "pivo"},
            { ItemCategory.WINE, "vino"},
            { ItemCategory.LIQUEUR, "liker"},
            { ItemCategory.HARD_LIQUOR, "žestoko piće"},
            { ItemCategory.HOT_CHOCOLATE, "vruća čokolada"},
            { ItemCategory.TEA, "čaj"},
            { ItemCategory.ENERGY_DRINK, "energetsko piće"},
            { ItemCategory.COCKTAIL, "koktel"},
            { ItemCategory.OTHER, "ostalo"}
        };
    }
}
