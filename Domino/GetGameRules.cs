using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
    Contiene a las implentacionesde las interfaces que modifican las reglas del juego, al crear una nuevaimplementacion basta con agregarla
    a la lista del metodo get correspondiente pa que la interface grafica realice las modificaciones automaticamente  
*/
static class GetGameRules<T>
{
    public static GameRules<T> Get(List<Token<T>> Tokens, int TokensByPlayer, int CantJugadores, ProgramedRules<T> PR)
    {
        BaseState<T> State = new BaseState<T>();
        ControladorDeDesarrollo<T> controler = new ControladorDeDesarrollo<T>(CantJugadores);
        return new GameRules<T>(TokensByPlayer,PR.ValidateMove, State, Tokens, PR.Order, controler,PR.ValorateToken, PR.GameFinisher, PR.Result);
    }
    public static ProgramedRules<T> BuildProgramedRules()
    {
        return new ProgramedRules<T>(GetValidateMove(), GetOrder(), GetValorateToken(), GetGameFinisher(), GetResult());
    }
    private static List<IValidateMove<T>> GetValidateMove()
    {
        List<IValidateMove<T>> P_ValidateMove = new List<IValidateMove<T>>();
        P_ValidateMove.Add(new ValidadorNormal<T>());
        P_ValidateMove.Add(new ValidadorEscalera<T>());
        return P_ValidateMove;
     
    }
    private static List<IOrder<T>> GetOrder()
    {
        List<IOrder<T>> P_Order = new List<IOrder<T>>();
        P_Order.Add(new NormalOrder<T>());
        P_Order.Add(new VariableOrder<T>());
        return P_Order;
    }
    private static List<IValorateToken<T>> GetValorateToken()
    {
        List<IValorateToken<T>> P_ValorateToken = new List<IValorateToken<T>>();
        P_ValorateToken.Add(new NormalValorator<T>());
        P_ValorateToken.Add(new MCDValorator<T>());
        return P_ValorateToken;
    }
    private static List<IGameFinisher<T>> GetGameFinisher()
    {
        List<IGameFinisher<T>> P_GameFinisher = new List<IGameFinisher<T>>();
        P_GameFinisher.Add(new NormalFinisher<T>());
        P_GameFinisher.Add(new OneTimePassFinisher<T>());
        return P_GameFinisher;
    }
    private static List<IResult<T>> GetResult()
    {
        List<IResult<T>> P_Result= new List<IResult<T>>();
        P_Result.Add(new IndividualPuntuation<T>());
        P_Result.Add(new TeamPuntuation<T>());
        return P_Result;
    }
}