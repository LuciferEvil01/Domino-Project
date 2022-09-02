using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    interface que indica el orden en que los jugadores juegan devolviendo un entero que 
    indica el indice del jugador a quien le toca
    Implementacioes
    #1: orden normal, los jugadores juegan uno tras otro en orden ascendente
    #2: orden variable, comienza normalmente pero cuando alguien se pasa el orden se invierte,
    permanece asi una rotacion y luego se vuelve a incertir cuando alguien mas se pase,
    el metodo actualizar controla el sentido en que se esta rotando    
*/
public interface IOrder<T> : IDescribable
{
    int Next(Player<T>[] jugadores);
    void Actualizar(Move<T> Move, Player<T> player);
}
public class VariableOrder<T> : IOrder<T>
{
    private int count = 0;
    private int Cicle { get; set; }
    private int last = -1;
    public bool sentido = true;
    public string Name()
    {
        return "Invertible";
    }
    public string Description()
    {
        return "Comienza normalmente pero cuando alguien se pasa el orden se invierte, permanece asi una rotacion y luego se vuelve a invertir cuando alguien mas se pase";
    }
    public int Next(Player<T>[] players)
    {
        if (Cicle == 0)
            Cicle = players.Length;
        if (sentido)
        {
            last++;
            if (last == players.Length)
                last = 0;
        }
        else
        {
            last--;
            if (last < 0)
                last = players.Length - 1;
        }

        return last;
    }
    public void Actualizar(Move<T> Move, Player<T> player)
    {

        if (Move.Type == Move.Pass)
        {
            if (count >= Cicle)
            {
                count = 0;
                sentido = !sentido;
            }
        }
        count++;
    }
}
public class NormalOrder<T> : IOrder<T>
{
    private int last = -1;
    public string Name()
    {
        return "Estandar";
    }
    public string Description()
    {
        return "Los jugadores juegan uno tras otro en orden ascendente";
    }
    public int Next(Player<T>[] jugadores)
    {
        if (last < 0 || last >= jugadores.Length - 1)
        {
            last = 0;
        }
        else
        {
            last++;
        }

        return last;
    }
    public void Actualizar(Move<T> Move, Player<T> player) { }
}

