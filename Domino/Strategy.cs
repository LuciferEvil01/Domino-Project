using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    en dependecia de las caracteristicas de cada jugada modifican su valor de score correspondiente. 
    Con n implementaciones de strategy se pueden crear n! jugadores
*/
public interface Strategy<T> : IDescribable
{
    void ModificateMoveScore(Move<T>[] Moves, int[] scores, GameRules<T> rules);
}
public class RandomStrategy<T> : Strategy<T>
{
    public void ModificateMoveScore(Move<T>[] Moves, int[] scores, GameRules<T> rules)
    {
        Random r = new Random();
        int rand = r.Next(0, scores.Length);
        scores[rand] += 1;
        scores[rand] *= 2;
    }
    public string Name()
    {
        return "RandomStrategy";
    }
    public string Description()
    {
        return "Aumenta el score de una jugada al azar";
    }
}
public class GreedyStrategy<T> : Strategy<T>
{
    public void ModificateMoveScore(Move<T>[] Moves, int[] scores, GameRules<T> rules)
    {
        for (int i = 0; i < Moves.Length; i++)
        {
            scores[i] += rules.Valorator.Valorate(Moves[i].InHand);
        }
    }
    public string Name()
    {
        return "GreedyStrategy";
    }
    public string Description()
    {
        return "Aumenta el score de una jugada segun el valor de la ficha en mano";
    }
}
public class PrioritizeDoubleStrategy<T> : Strategy<T>
{
    public void ModificateMoveScore(Move<T>[] Moves, int[] scores, GameRules<T> rules)
    {
        for (int i = 0; i < Moves.Length; i++)
        {
            if (Moves[i].InHand.FirstFace.Equals(Moves[i].InHand.SecondFace))
            {
                scores[i] += 1;
                scores[i] *= 2;
            }
        }
    }
    public string Name()
    {
        return "PrioritizeDoubleStrategy";
    }
    public string Description()
    {
        return "Aumenta el score de una jugada si la ficha en mano es doble";
    }
}
public class HaveStrategy<T> : Strategy<T>
{
    List<Token<T>> Hand;
    public HaveStrategy(List<Token<T>> Hand)
    {
        this.Hand = Hand;
    }
    public void ModificateMoveScore(Move<T>[] Moves, int[] scores, GameRules<T> rules)
    {
        for (int i = 0; i < Moves.Length; i++)
        {
            if (Moves[i].IndexInHand == 0)
                ModificateMoveScore(Moves[i].InHand.SecondFace, scores, rules, i);
        }
    }
    public void ModificateMoveScore(T Face, int[] scores, GameRules<T> rules, int index)
    {
        foreach (var item in Hand)
        {
            int x;
            if (rules.validador.Validate(item, Face, out x))
            {
                scores[index] += 2;
            }
        }
    }
    public string Name()
    {
        return "HaveStrategy";
    }
    public string Description()
    {
        return "Aumenta el score de una jugada entre mas fichas se tengan para jugar en la nueva cara que queda";
    }
}