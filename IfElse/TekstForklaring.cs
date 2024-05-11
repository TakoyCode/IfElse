using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElse
{
    internal class TekstForklaring
    {
        public static void Run()
        {
            // if, else if og else fungerer på samme måte som i JavaScript:
            // En condition er en betingelse om noe. Noe må være sant eller usant i dataspråket true eller false,.
            
            // Vi har verditypen bool som kan si noe om noe er true eller false, vi har også betingelser.
            // Det kan bære om en verdi er større enn, mindre enn, likt eller ulikt en annen verdi.
            // Man sammen ligner altså noen verdier og finner ut som betingelsene man ser etter er sant eller ikke.

            int liteTall = 2;
            int størreTall = 5;

            if (liteTall < størreTall) // her er betingelsen at liteTall skal være mindre enn størreTall
            {
                // if kan dermed leses som dersom liteTall mindre enn størreTall
                // utfør kode inni klammene
            }
            else
            {
                // dersom betingelsen i parantesen på if-setningen ikke er sann
                // ( dersom liteTall ikke er mindre enn størreTall )
                // skal man heller utføre koden som finnes her inne
            }


        }
    }
}
