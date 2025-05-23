using UnityEngine;
using System.Collections.Generic;

public abstract class SymbolBase : ISymbol
{
    public abstract string SymbolName { get; }
    public abstract Sprite SymbolIcon { get; }

    public abstract List<string> CombinableWith();

    public virtual ISymbol Combine(ISymbol other)
    {
        return SymbolFactory.TryCombine(this, other);
    }
}
