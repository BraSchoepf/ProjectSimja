
using System.Collections.Generic;
using UnityEngine;

public interface ISymbol 
{

    string SymbolName { get; }
    Sprite SymbolIcon { get; }
    List<string> CombinableWith();//Con quien es combinable
    ISymbol Combine(ISymbol other);
}
