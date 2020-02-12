using System;
using System.Collections.Generic;
using System.Text;

namespace P3_Kol2_poprawa_nr3
{
    interface IKopiarka:ISkaner,IDrukarka
    {
        string Kopiuj(string tekst);


    }

}
