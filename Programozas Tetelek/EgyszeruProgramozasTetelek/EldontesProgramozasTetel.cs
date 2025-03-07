using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programozas_Tetelek.EgyszeruProgramozasTetelek
{
    internal class EldontesProgramozasTetel
    {
        class Eldontes
        {
            public static bool VanTulajdonsaguElem(int[] tomb, Func<int, bool> tulajdonsag)
            {
                int i = 0;
                while (i < tomb.Length && !tulajdonsag(tomb[i])) // Amíg nem találunk megfelelő elemet
                {
                    i++;
                }
                return i < tomb.Length; // Igaz, ha találtunk ilyen elemet
            }
        }

    }
}
