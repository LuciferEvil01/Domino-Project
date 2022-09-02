using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*una clase que usa recursividad simple para generar el conjunto total de fichas a traves 
de los posibles valores de las caras de estas
*/
public class TokensCreator<T>
{
    private List<Token<T>> Miset_ = new List<Token<T>>();
    public List<Token<T>> Miset
    {
        get { return Miset_; }
    }
    public TokensCreator(int CantidaddeCaras, T[] PosiblesCaras)
    {
        SetDeTokens(new T[CantidaddeCaras], PosiblesCaras, 0, 0);
    }
    private void SetDeTokens(T[] Tokenactual, T[] PosiblesCaras, int indice, int menor)
    {
        if (indice == Tokenactual.Length)
        {
            Token<T> TokenActual = new Token<T>(Tokenactual);
            Miset_.Add(TokenActual);
            return;
        }

        for (int i = menor; i < PosiblesCaras.Length; i++)
        {
            Tokenactual[indice] = PosiblesCaras[i];
            SetDeTokens((T[])Tokenactual.Clone(), PosiblesCaras, indice + 1, i);
        }
    }
}

