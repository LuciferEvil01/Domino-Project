using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    tras recibir las reglas del juego y los jugadores, es la que lleva a cabo el juego,
    mezcla aleatoriamente las fichas del juego, le asigna sus fichas a cada jugador 
    y luego comienza la pertida 
*/
public class Game<T>
{
    public GameRecord<T> Single(GameRules<T> rules, Player<T>[] gamers)
    {
        GameRecord<T> Record = new GameRecord<T>();

        rules.Tokens = Auxiliares<T>.Mezclar(rules.Tokens);
        Auxiliares<T>.PrepararJugadores(rules.TokensByPlayer, gamers, rules.Tokens);

        while (true)
        {
            int InTurn = rules.Ordenador.Next(gamers);


            Move<T>[] validas = ValidMoves<T>.GetAll(gamers[InTurn], rules.State, rules.validador);

            Move<T> actual = gamers[InTurn].MoveActual(validas, rules);

            rules.State.Actualizar(gamers[InTurn], actual, rules, Record);
            bool end = rules.Finisher.Condition(gamers[InTurn], rules);

            if (end)
            {
                Record.Mensajes.Add(rules.result.Winner(gamers, rules));
                break;
            }

        }
        Record.Registro = rules.State.Registro;
        return Record;
    }
}




