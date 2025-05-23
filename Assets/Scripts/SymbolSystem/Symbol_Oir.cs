using System.Collections.Generic;
using UnityEngine;

public class Symbol_Oir : SymbolBase
{
    public override string SymbolName => "Oír";
    public override Sprite SymbolIcon => Resources.Load<Sprite>("Icons/Oir");

    public override List<string> CombinableWith() => new List<string> { "Interpretación" };
}

