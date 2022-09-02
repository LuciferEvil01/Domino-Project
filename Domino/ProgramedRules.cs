using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    contiene las listas de las implentaciones de las interfaces e indica cuales de estas implementaciones se va a usar
*/
   
    public class ProgramedRules<T>
    {
        List<IValidateMove<T>> P_ValidateMove { get; set; }
        List<IOrder<T>> P_Order { get; set; }
        List<IValorateToken<T>> P_ValorateToken { get; set; }
        List<IGameFinisher<T>> P_GameFinisher { get; set; }
        List<IResult<T>> P_Result { get; set; }

        public ProgramedRules(List<IValidateMove<T>> P_ValidateMove, List<IOrder<T>> P_Order, List<IValorateToken<T>> P_ValorateToken, List<IGameFinisher<T>> P_GameFinisher,
           List<IResult<T>> P_Result)
        {
        this.P_ValidateMove = P_ValidateMove;
        this.P_Order = P_Order;
        this.P_ValorateToken = P_ValorateToken;
        this.P_GameFinisher = P_GameFinisher;
        this.P_Result = P_Result;
        }
        int i_ValidateMove;
        int i_Order;
        int i_ValorateToken;
        int i_GameFinisher;
        int i_Result;
        public IValidateMove<T> ValidateMove { get { return P_ValidateMove[i_ValidateMove]; } }
        public IOrder<T> Order { get { return P_Order[i_Order]; } }
        public IValorateToken<T> ValorateToken { get { return P_ValorateToken[i_ValorateToken]; } }
        public IGameFinisher<T> GameFinisher { get { return P_GameFinisher[i_GameFinisher]; } }
        public IResult<T> Result { get { return P_Result[i_Result]; } }

    public IDescribable Upper(string x)
    {
        char i = x.ElementAt(x.Length - 1);

        switch (i)
        {
            case '1':
                i_ValidateMove = Upper(i_ValidateMove, P_ValidateMove.Count);
                return ValidateMove;
            case '2':
                i_Order = Upper(i_Order, P_Order.Count);
                return Order;
            case '3':
                i_ValorateToken = Upper(i_ValorateToken, P_ValorateToken.Count);
                return ValorateToken;
            case '4':
                i_GameFinisher = Upper(i_GameFinisher, P_GameFinisher.Count);
                return GameFinisher;
            case '5':
            default:
                i_Result = Upper(i_Result, P_Result.Count);
                return Result;
        }
    }
    private int Upper(int i, int lenth)
    {
        if (i + 1 == lenth)
            return 0;
        else
            return i + 1;

    }

}
   



