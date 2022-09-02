using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    indica el valor numerico de una ficha lo que resulta util para determinar al vencedor
    y para un jugador que base su estrategia en eso
    Implementaciones
    #1: el valor de una ficha es el valor total de sus caras
    #2: el valor de una ficha es el maximo comun divisor entre sus caras
*/
public interface IValorateToken<T> : IDescribable
{
    int Valorate(Token<T> Token);
}

public class NormalValorator<T> : IValorateToken<T>
{
    public string Name()
    {
        return "Estandar";
    }
    public string Description()
    {
        return "El valor de una ficha es el valor total de sus caras";
    }
    public int Valorate(Token<T> Token)
    {
        int val = 0;
        for (int i = 0; i < Token.Caras.Length; i++)
        {
            try
            {
                val += Convert.ToInt32(Token.Caras[i]);
            }
            catch { }
        }
        return val;
    }
}
public class MCDValorator<T> : IValorateToken<T>
{
    public string Name()
    {
        return "MCD";
    }
    public string Description()
    {
        return "El valor de una ficha es el maximo comun divisor entre sus caras";
    }
    public int Valorate(Token<T> Token)
    {
        int[] values = Auxiliares<T>.ConvertToInt(Token.Caras);
        if (values.Contains(0))
            return 0;
        return values.Aggregate(MCD);
    }

    private int MCD(int x, int y)
    {
        if (x % y == 0)
            return y;
        return MCD(y, x % y);
    }
}

