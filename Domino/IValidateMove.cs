using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    interface que determina las condiciones para que una ficha se pueda jugar, de poderse
    jugar regresa la cara de la ficha, de lo contrario regresa -1
    Implementaciones:
    #1: la forma usual
    #2: la cara de la ficha debe ser mayor en 1 a la cara de la mesa, el valor 0 se puede
    jugar solo por la cara de la mesa de mayor valor
*/
public interface IValidateMove<T> : IDescribable
{
    bool Validate(Token<T> Token, T OnTable, out int index);
}

public class ValidadorNormal<T> : IValidateMove<T>
{
    public string Name()
    {
        return "Estandar";
    }
    public string Description()
    {
        return "Una jugada es valida si al menos una cara de la ficha coincide con una de las caras de la mesa";
    }
    public bool Validate(Token<T> Token, T OnTable, out int index)
    {
        for (int i = 0; i < Token.Caras.Length; i++)
        {
            if (OnTable.Equals(Token.Caras[i]))
            {
                index = i;
                return true;
            }
        }
        index = -1;
        return false;
    }
}
public class ValidadorEscalera<T> : IValidateMove<T>
{
    public string Name()
    {
        return "Escalera";
    }
    public string Description()
    {
        return "La cara de la ficha debe ser mayor en 1 a la cara de la mesa, el valor 0 se puede jugar solo por la cara de la mesa de mayor valor";
    }
    public bool Validate(Token<T> Token, T OnTable, out int index)
    {
        int[] TokenNum = Auxiliares<T>.ConvertToInt(Token.Caras);
        int TableNum = Auxiliares<T>.ConvertToInt(OnTable);

        if (TokenNum.Contains(0))
        {
            index = TokenNum.ToList().IndexOf(0);
            return true;
        }
        for (int i = 0; i < TokenNum.Length; i++)
        {
            if (TableNum == TokenNum[i] - 1)
            {
                index = i;
                return true;
            }
        }
        index = -1;
        return false;

    }
}


