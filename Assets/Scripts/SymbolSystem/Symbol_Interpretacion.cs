using System.Collections.Generic;
using UnityEngine;

public class Symbol_Interpretacion : SymbolBase
{
    public override string SymbolName => "Interpretación";
    public override Sprite SymbolIcon => Resources.Load<Sprite>("Icons/Interpretacion");

    public override List<string> CombinableWith() => new List<string> { "Oír" };
}
