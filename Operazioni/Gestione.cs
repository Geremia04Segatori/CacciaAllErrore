﻿using System;

namespace Operazioni
{
    public class Gestione
    
    {
        public static long CalcoloMisterioso(int n)
        {
            long valore = 2;
            if (n == 0)
                valore = 1;
            else
            {
                for (int i = 1; i <= n; i++)
                    valore = valore * i;
            }

            return valore;
        }

    }
}
