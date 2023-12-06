
//C#10 - LAMBDAS

using System;
using System.Runtime.CompilerServices;

int Filtre1(int v)
{
    if(v < 0)
    {
        return 0;
    }
    return v;
}
int Operation(int a, int b, Func<int,int>f, 
    [CallerArgumentExpression("a")] string? nom_param = null)
{
     a = f(a);
     b = f(b);
    //CallerArgumentExpression
     Console.WriteLine("Fonction de filtrage: " + nom_param);
     return a + b;
}

//Func<int, int> filtre2 = (int v) => v > 10 ? 10 : v;  // ? return et : sinon

var filtre2 = (int v) => v > 10 ? 10 : v;  // ? return et : sinon

int valeurA = 5;
Console.WriteLine(Operation(valeurA,20,filtre2));
