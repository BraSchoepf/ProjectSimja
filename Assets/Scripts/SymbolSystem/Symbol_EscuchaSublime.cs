using System.Collections.Generic;
using UnityEngine;

public class Symbol_EscuchaSublime : SymbolBase
{
    public override string SymbolName => "Escucha Sublime";
    public override Sprite SymbolIcon => null;

    public override List<string> CombinableWith()
    {
        return new List<string>(); // o futuras combinaciones
    }
}
