using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    clase que crea los jugadores usando dos array de igual dim que indican su tipo y 
    equipo, sin embargo como estos son ajenos al tipo de domino que van a jugar, no se
    les asignan sus fichas aun 
*/
public static class PlayerCreator<T>
{
    private static Player<T> CreateRandom(int i, int team)
    {
        Random r = new Random();
        return CreatePlayer(i, r.Next(0, 3), team);
    }
    public static Player<T>[] Create(int[] Types, int[] teams)
    {
        Player<T>[] players = new Player<T>[Types.Length];

        for (int i = 0; i < Types.Length; i++)
        {
            players[i] = CreatePlayer(i, Types[i], teams[i]);
        }
        return players;
    }
    private static Player<T> CreatePlayer(int i, int Type, int team)
    {
        switch (Type)
        {
            case 0:
                return new PlayerRandom<T>(i, team);
            case 1:
                return new PlayerGreedy<T>(i, team);
            case 2:
                return new PlayerCounter<T>(i, team);
            default:
                return CreateRandom(i, team);
        }

    }

}

