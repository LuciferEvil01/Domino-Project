using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    clase abstracta que sirve de base para los jugadores, estos se diferencian solo en su
    diferente forma de escoger una jugada de entre un conjunto de jugadas validas
    Estos jugadores funcionan recibiendo un array de jugadas validas. Crean un array numerico que indica el score que le dana cada jugada.
    Luego usan uno o varios objetos strategy para modificar esos score y devolver la jugada de score mas alto
*/
public abstract class Player<T>:IDescribable
{
    public int name { get; protected set; }
    public List<Token<T>> Mano { get; protected set; }
    public int Team { get; protected set; }
    public Strategy<T>[] Strategies;
    public Player(int Name, int Team,params Strategy<T>[] Strategies)
    {
        name = Name;
        Mano = new List<Token<T>>();
        this.Team = Team;
        this.Strategies = Strategies;
    }
    public virtual void Asigar(List<Token<T>> disponibles, int asign)
    {
        for (int i = 0; i < asign; i++)
        {
            Mano.Add(Auxiliares<T>.Take(disponibles));
        }
    }
    public string Name()
    {
        return Convert.ToString(name);
    }
    public string Description()
    {
        string description = "";
        foreach (var item in Strategies)
        {
            description += item.Description();
            description += ". ";
        }
        return description;
    }

    public virtual Move<T> MoveActual(Move<T>[] PosiblesMoves, GameRules<T> rules)
    {

        if (PosiblesMoves.Length == 0)
            return new Move<T>();
        int[] scores = new int[PosiblesMoves.Length];
        foreach (var item in Strategies)
        {
            item.ModificateMoveScore(PosiblesMoves, scores, rules);
        }
        Array.Sort(scores, PosiblesMoves);
        return PosiblesMoves[PosiblesMoves.Length - 1];
    }
}

public class PlayerRandom<T> : Player<T>
{
    public PlayerRandom(int Name, int Team) : base(Name, Team, new RandomStrategy<T>()) { }
}
public class PlayerGreedy<T> : Player<T>
{
    public PlayerGreedy(int Name, int Team) : base(Name, Team,new GreedyStrategy<T>(),new PrioritizeDoubleStrategy<T>()) { }
}

public class PlayerCounter<T> : Player<T>
{
    public PlayerCounter(int Name, int Team) : base(Name, Team,new Strategy<T>[1])
    {
        Strategies[0] = new HaveStrategy<T>(Mano);
    }
}


