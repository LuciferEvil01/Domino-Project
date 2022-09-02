using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Clase que agrupa a metodos utiles para diferentes partes del codigo, se divide en 3
partes segun su funcion:
#1 contiene metodos relacionados con el juego como ordenar aleatoriamente las fichas, llevar
el valor de una ficha a cuantitativo, etc.
#2 contiene metodos para imprimir en consola, si bien no son necesarios para el funcionamiento
del programa me resultaron utiles en la deteccion de bugs por lo que creo seran eficaces
para el mantenimiento futuro
#3 Contiene el metodo ValidateSettings que recive las opcienes seleccionadas por los 
usuarios en la interfaz grafica, analiza si son validas y regresa un objeto GameRules
y un array de jugadores con lo que posteriormente se jugaran  
*/
public static class Auxiliares<T>
{
    public static int ValoratePlayer(Player<T> P1, IValorateToken<T> valorator)
    {
        int v1 = 0;
        for (int i = 0; i < P1.Mano.Count; i++)
        {
            v1 += valorator.Valorate(P1.Mano[i]) + 1;
        }
        return v1;
    }
    public static int ConvertToInt(T Face)
    {
        int x;
        try { x = Convert.ToInt32(Face); }
        catch { x = 0; }
        return x;
    }
    public static int[] ConvertToInt(T[] Faces)
    {
        int[] values = new int[Faces.Length];
        for (int i = 0; i < Faces.Length; i++)
        {
            values[i] = ConvertToInt(Faces[i]);
        }
        return values;
    }
    public static List<Token<T>> Mezclar(List<Token<T>> miset)
    {
        Random random = new Random();

        int[] guide = new int[miset.Count];

        Token<T>[] misetaux = new Token<T>[miset.Count];

        for (int i = 0; i < guide.Length; i++)
        {
            int value = random.Next(0, guide.Length * 2);
            misetaux[i] = miset[i];
            guide[i] = value;
        }

        Array.Sort(guide, misetaux);
        return misetaux.ToList();
    }
    public static void PrepararJugadores(int n, Player<T>[] players, List<Token<T>> Tokens)
    {
        for (int i = 0; i < players.Length; i++)
        {
            players[i].Asigar(Tokens, n);
        }
    }
    public static Token<T> Take(List<Token<T>> Tokens)
    {
        Token<T> Token = Tokens[0];
        Tokens.Remove(Token);
        return Token;
    }
    public static int NoCanPlayNum(PlayerDates<T>[] dates)
    {
        int total = 0;
        for (int i = 0; i < dates.Length; i++)
        {
            if (dates[i].NoCanPlay)
                total++;
        }
        return total;
    }
    public static void PrintPlayerHand(Player<T> player)
    {
        System.Console.WriteLine("Player {0}:", player.name);
        PrintTokens(player.Mano);
    }
    public static void PrintTokens(List<Token<T>> Tokens)
    {
        PrintTokens(Tokens.ToArray());
    }
    public static void PrintNumTokens(Player<T> player)
    {
        System.Console.WriteLine("Player {0}: {1} Tokens", player.name, player.Mano.Count);
    }
    public static void PrintTokens(Token<T>[] Tokens)
    {
        foreach (var item in Tokens)
        {
            var x = item.Caras[0];
            var y = item.Caras[1];
            System.Console.Write("[{0},{1}] ", x, y);
        }
        System.Console.WriteLine();
    }
    public static void PrintAll(Player<T>[] players)
    {
        foreach (var player in players)
        {
            PrintPlayerHand(player);
        }
    }
    public static bool ValidateSttings(T[] PosiblesCaras, int[] IAs, int[] Teams,
                            int TokensByPlayer, int NumPlayers, ProgramedRules<T> PR,
                            out string Error, out Player<T>[] gamers,
                            out GameRules<T> rules)
    {
        TokensCreator<T> creator = new TokensCreator<T>(2, PosiblesCaras);
        int NecessaryTokens = TokensByPlayer * NumPlayers;
        int NumTokens = creator.Miset.Count;
        if (NecessaryTokens > NumTokens)
        {
            Error = "La cantidad de fichas es insufiiente para asigarle a cada jugador su mano";
            gamers = null;
            rules = null;
            return false;

        }
        if (IAs.Length == 0 || IAs.Length == 1)
        {
            Error = "Por favor implemente al menos dos jugadores";
            gamers = null;
            rules = null;
            return false;
        }
        if (PosiblesCaras.Length < 2)
        {
            Error = "Por favor implemente al menos dos caras posibles";
            gamers = null;
            rules = null;
            return false;
        }

        Error = "";
        gamers = PlayerCreator<T>.Create(IAs, Teams);
        rules = GetGameRules<T>.Get(creator.Miset, TokensByPlayer, NumPlayers,PR);
        return true;
    }

}
