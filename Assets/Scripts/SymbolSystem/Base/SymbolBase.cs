using System.Collections.Generic;
using UnityEngine;

public class SymbolBase : MonoBehaviour, ISymbol
{
    [SerializeField] private SymbolData data;

    public string SymbolName => data.symbolName;
    public Sprite SymbolIcon => data.icon;

    public List<string> CombinableWith()
    {
        return new List<string>(); // podés llenarlo después si querés
    }

    public ISymbol Combine(ISymbol other)
    {
        Debug.Log($"Combinando {SymbolName} con {other.SymbolName} desde SymbolBase");
        return null; // En este caso se delega al SymbolCombiner externo
    }

    public void Initialize(SymbolData symbolData)
    {
        data = symbolData;

    
    }

    public SymbolData GetData() => data;
}

