using System;

public static class Grani
{
    public static ulong Quadrato(int n)
    {
        if (n == 0)
            throw new ArgumentOutOfRangeException("Il valore deve essere maggiore di 0");
        if (n < 0)
            throw new ArgumentOutOfRangeException("Il valore deve essere maggiore di 0");
        if (n > 64)
            throw new ArgumentOutOfRangeException("Il valore deve essere maggiore di 0");

        //array contenente le 64 celle della scacchiera
        ulong[] arrayScacchiera = ComponiQuadrato();

        return arrayScacchiera[n-1];
    }

    public static ulong Total()
    {
        ulong Qta=0;
        ulong[] arrayScacchiera = ComponiQuadrato();

        for(int i=0;i<arrayScacchiera.Length;i++)
        {
            Qta+=arrayScacchiera[i];
        }

        return Qta;
    }

    public static ulong[] ComponiQuadrato()
    {
        ulong[] arrayScacchiera = new ulong[64];

        arrayScacchiera[0]=1;

        for(int i=1;i<arrayScacchiera.Length;i++)
        {
            arrayScacchiera[i]=arrayScacchiera[i-1]*2;
        }
        return arrayScacchiera;
    }
}