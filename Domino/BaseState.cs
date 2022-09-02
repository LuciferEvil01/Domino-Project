using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
clase que controla el estado del juego almacenando las fichas activas(por las que se puede jugar)
en la mesa y actualizando continuamente este, tiene ademas un registro de cada jugada hecha
en el juego
*/
public class BaseState<T>
{
    public List<T> TokensActivas = new List<T>();
    public List<Tuple<Player<T>, Move<T>>> Registro = new List<Tuple<Player<T>, Move<T>>>();
    public T FirstPosition
    {
        get
        {
            return TokensActivas[0];
        }
    }
    public T SecondPosition
    {
        get
        {
            return TokensActivas[1];
        }
    }

    public virtual void Actualizar(Player<T> player, Move<T> Move, GameRules<T> rules, GameRecord<T> Record)
    {
        Registro.Add(new Tuple<Player<T>, Move<T>>(player, Move));

        rules.Ordenador.Actualizar(Move, player);
        string mensaje = "";
        if (Move.Type == Move.Pass)
        {
            rules.contoler.NoLLevaDetectado(player.name, this);
            mensaje = "Player " + player.name + " se pasa";
        }
        if (Move.Type == Move.Open)
        {
            List<T> NuevasCaras = ((T[])(Move.InHand.Caras).Clone()).ToList();
            mensaje = "Player " + player.name + " empieza con " + Move.InHand;

            player.Mano.Remove(Move.InHand);
            TokensActivas.AddRange(NuevasCaras);


        }
        if (Move.Type == Move.NormalMove)
        {
            mensaje = "Player " + player.name + " juega " + Move.InHand + " en " + Move.OnTable;

            int index = TokensActivas.IndexOf(Move.OnTable);
            TokensActivas.Remove(Move.OnTable);
            rules.contoler.RestablecerNoLLeva(Convert.ToInt32(player.name));

            List<T> NuevasCaras = ((T[])(Move.InHand.Caras).Clone()).ToList();
            NuevasCaras.RemoveAt(Move.IndexInHand);

            player.Mano.Remove(Move.InHand);

            for (int i = 0; i < NuevasCaras.Count; i++)
            {
                TokensActivas.Insert(index+0,NuevasCaras[i]);
            }
            


        }
        Record.Mensajes.Add(mensaje);
        Record.CarasDisponibles.Add(new Tuple<T, T>(TokensActivas[0], TokensActivas[1]));



    }
}


