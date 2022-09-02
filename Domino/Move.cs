using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    clase que representa una jugada, puede ser de tres tipos apertura, jugada normal y pasarse
    inicalmente lo establecimos como una interface con tres clases que la implementen pero
    realmente no vi ningun punto en comun entre una jugada normal y pasarse por lo que me
    parecio un uso forzado de interface
    Por tal motivo se opto por una clase unica con tres constructores y una propiedad type
    indicando el constructor usado  

*/
public class Move<T>
{
    public string Open { get { return "Open"; } }
    public string NormalMove { get { return "NormalMove"; } }
    public string Pass { get { return "Pass"; } }
    public string Type { get; private set; }
    public int IndexInHand { get; private set; }
    public int IndexOnTable { get; private set; }
    public Move()
    {
        Type = Pass;
    }
    public Move(Token<T> InHand)
    {
        this.In_Hand = InHand;
        Type = Open;
    }
    public Move(Token<T> InHand, int IndexInHand, T OnTable,int IndexOnTable)
    {
        this.In_Hand = InHand;
        this.On_Table = OnTable;
        this.IndexInHand = IndexInHand;
        this.IndexOnTable = IndexOnTable;
        Type = NormalMove;
    }

    private Token<T> In_Hand;
    public Token<T> InHand
    {
        get
        {
            if (Type != Pass)
                return In_Hand;
            else
                throw new Exception("La juagada es pass");
        }
    }
    private T On_Table;
    public T OnTable
    {
        get
        {
            if (Type == NormalMove)
                return On_Table;
            else
                throw new Exception("La juagada es apertura");
        }
    }
    public double MoveValue(IValorateToken<T> valorator)
    {
        if (Type == Pass)
            return 0;
        return valorator.Valorate(this.InHand);
    }

}


