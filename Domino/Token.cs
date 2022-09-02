using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    clase que representa a cada ficha del juego mediante una array de genericos, este 
    array que representa la cantidad de caras de la ficha siempre se le dara length 2
*/
public class Token<T>
{
    public T FirstFace
    {
        get
        { return Caras[0]; }
    }
    public T SecondFace
    {
        get
        {
            if (Caras.Length < 2) return Caras[0];
            else return Caras[1];
        }
    }
    public T[] Caras { get; private set; }
    public Token(T[] Caras)
    {
        this.Caras = Caras;
    }
    public override string ToString()
    {
        string Name = "";
        for (int i = 0; i < Caras.Length; i++)
        {
            Name += Convert.ToString(Caras[i]);

            if (i!=Caras.Length-1)
                Name += "/";
        }
        return Name;
    }
}

