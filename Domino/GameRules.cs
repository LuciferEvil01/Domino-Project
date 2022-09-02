using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    contiene las diferntes reglas indicadas por el usuario bajo las cuales funciona el juego
*/
public class GameRules<T>
{
    public int TokensByPlayer { get; set; }
    public IValidateMove<T> validador { get; set; }
    public BaseState<T> State { get; set; }
    public List<Token<T>> Tokens { get; set; }
    public IOrder<T> Ordenador { get; set; }
    public ControladorDeDesarrollo<T> contoler { get; set; }
    public IValorateToken<T> Valorator { get; set; }
    public IGameFinisher<T> Finisher { get; set; }
    public IResult<T> result { get; set; }
    public GameRules(int TokensByPlayer, IValidateMove<T> validador, BaseState<T> State, List<Token<T>> Tokens, IOrder<T> Ordenador, ControladorDeDesarrollo<T> contoler, IValorateToken<T> Valorator, IGameFinisher<T> Finisher, IResult<T> result)
    {
        this.TokensByPlayer = TokensByPlayer;
        this.State = State;
        this.validador = validador;
        this.Tokens = Tokens;
        this.Ordenador = Ordenador;
        this.contoler = contoler;
        this.Valorator = Valorator;
        this.Finisher = Finisher;
        this.result = result;
    }
}