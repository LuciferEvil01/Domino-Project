using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*contiene una lista de los tipos de jugadores implementados, esto solo para proveer a la interface gafica la descripcion de cada uno*/

public class ProgramedPlayers<T>
{
    public List<Player<T>> Types { get; private set; }
    public ProgramedPlayers()
    {
        Types = new List<Player<T>>();
        Types.Add(new PlayerRandom<T>(0, 0));
        Types.Add(new PlayerGreedy<T>(0, 0));
        Types.Add(new PlayerCounter<T>(0, 0));
    }
}

