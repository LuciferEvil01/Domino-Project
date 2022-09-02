using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    interface que se ejecuta despues de cada jugada y analiza si el juego ha terminado o
    no estableciendo las condiciones para esto
    Implementaciones:
    #1 Las condiciones usuales, si nadie lleva o si alguien se pego
    #2 Mantiene las condiciones anteriores y agrega que el juego termina si todos 
    los jugadores se han pasado al menos una vez 
*/
public interface IGameFinisher<T> : IDescribable
{
    bool Condition(Player<T> player, GameRules<T> rules);
}
public class NormalFinisher<T> : IGameFinisher<T>
{
    public bool Condition(Player<T> player, GameRules<T> rules)
    {
        if (player.Mano.Count == 0)
        {
            
            return true;
        }
        if (rules.contoler.NoOneHas())
        {
            System.Console.WriteLine("None any player can play");
            return true;
        }
        return false;
    }
    public string Name()
    {
        return "Estandar";
    }
    public string Description()
    {
        return "El juego termina si un jugador se queda sin fichas o si ningun jugador puede hacer una jugada valida";
    }
}
public class OneTimePassFinisher<T> : IGameFinisher<T>
{
    bool[] Mask = null;
    public bool Condition(Player<T> player, GameRules<T> rules)
    {
        if (Mask == null)
            Mask = new bool[rules.contoler.Dates.Length];

        for (int i = 0; i < rules.contoler.Dates.Length; i++)
        {
            if (rules.contoler.Dates[i].NoCanPlay)
                Mask[i] = true;
        }

        if (Mask.All(x => x))
            return true;

        return new NormalFinisher<T>().Condition(player, rules);

    }
    public string Name()
    {
        return "Pasado";
    }
    public string Description()
    {
        return "Ademas de las condiciones dela forma estandar, el juego termina si todos los jugadores se han pasado al menos una vez";
    }
}
