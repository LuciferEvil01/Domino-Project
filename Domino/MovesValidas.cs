using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    clase que determina todas las jugadas que puede hacer un player de acuardo a las 
    reglas en curso, al player ya le corresponde selccionar cual hara
*/
public static class ValidMoves<T>
{
    public static Move<T>[] GetAll(Player<T> player, BaseState<T> State, IValidateMove<T> Validator)
    {
        if (State.TokensActivas.Count == 0)
            return ValidarPrimeraMove(player, State);


        List<Move<T>> MovesValidas = new List<Move<T>>();

        for (int i = 0; i < State.TokensActivas.Count; i++)
        {
            MovesValidas.AddRange(GetAll(player, State.TokensActivas[i], Validator, i));
        }
        return MovesValidas.ToArray();
    }
    private static Move<T>[] GetAll(Player<T> player,T Face, IValidateMove<T> Validator,int IndexOnTable)
    {
        List<Move<T>> MovesValidas = new List<Move<T>>();

        for (int i = 0; i < player.Mano.Count; i++)
        {
            int index;
            if (Validator.Validate(player.Mano[i], Face, out index))
                MovesValidas.Add(new Move<T>(player.Mano[i], index, Face,IndexOnTable));
        }
        return MovesValidas.ToArray();
    }
    private static Move<T>[] ValidarPrimeraMove(Player<T> player, BaseState<T> State)
    {
        Move<T>[] MovesValidas = new Move<T>[player.Mano.Count];

        for (int i = 0; i < MovesValidas.Length; i++)
        {
            MovesValidas[i] = new Move<T>(player.Mano[i]);
        }

        return MovesValidas;
    }
}
