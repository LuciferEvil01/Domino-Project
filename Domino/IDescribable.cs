using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Interface ques implementada por la mayoria de las otras interfacesdel programa para obligar las clases que implementen estas a dar una 
descpcion de su funcionamiento*/
public interface IDescribable
{
    string Name();
    string Description(); 
}

