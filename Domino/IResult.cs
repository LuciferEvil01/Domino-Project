using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    interface que una vaz terminado el juego, puntua a cada jugador y determina el vencedor
    Implementaciones:
    #1: la puntuacion es individual y la victoria de un jugador equivale a la victoria de
    su equipo
    #2: la puntuacion del equipo es colectiva, si se esta jugando sin equipos esta equivale
    a la anterior pero sino se puede dar el caso en que un jugador se pegue y aun asi su
    equipo pierda
*/
public interface IResult<T> : IDescribable
{
    string Winner(Player<T>[] players, GameRules<T> rules);
}
public class IndividualPuntuation<T> : IResult<T>
{
    public string Name()
    {
        return "Individual";
    }
    public string Description()
    {
        return "La puntuacion es individual y la victoria de un jugador equivale a la victoria de su equipo";
    }
    public string Winner(Player<T>[] players, GameRules<T> rules)
    {
        Player<T>[] temp = (Player<T>[])players.Clone();
        int[] keys = new int[players.Length];

        for (int i = 0; i < players.Length; i++)
        {
            keys[i] = Auxiliares<T>.ValoratePlayer(players[i], rules.Valorator);
        }

        Array.Sort(keys, temp);

        Player<T> win = temp[0];
        string result = ("Player " + win.name + " team " + win.Team + " winns");
        return result;
    }

}
public class TeamPuntuation<T> : IResult<T>
{
    public string Name()
    {
        return "Equipos";
    }
    public string Description()
    {
        return "La puntuacion es colectiva y a cada equipo le corresponde la suma de los puntos de sus integrantes";
    }
    public string Winner(Player<T>[] players, GameRules<T> rules)
    {
        Dictionary<int, int> Puntuations = new Dictionary<int, int>();
        foreach (Player<T> item in players)
        {
            int points = Auxiliares<T>.ValoratePlayer(item, rules.Valorator);
            if (Puntuations.Keys.Contains(item.Team))
            {
                Puntuations[item.Team] += points;
            }
            else
            {
                Puntuations.Add(item.Team, points);
            }
        }
        int[] teams = (int[])Puntuations.Keys.ToArray().Clone();
        Array.Sort(Puntuations.Values.ToArray(), teams);
        string result = ("Team " + teams[0] + " winns");
        return result;
    }
}


