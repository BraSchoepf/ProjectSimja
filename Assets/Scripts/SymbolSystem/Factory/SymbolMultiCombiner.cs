using System.Collections.Generic;
using UnityEngine;

public class SymbolMultiCombiner : MonoBehaviour
{
    public List<SymbolMultiCombinationData> multiCombinations;

    public SymbolData Combine(List<SymbolData> inputsSymbols)
    {
        foreach (var combo in multiCombinations)
        {
            if (CompareSymbolLists(combo.inputs, inputsSymbols))
            {
                Debug.Log("¡Combinación múltiple encontrada!");
                return combo.result;
            }
                       
        }
        Debug.Log("No se encontró combinación múltiple.");
        return null;
    }

    private bool CompareSymbolLists(List<SymbolData> a, List<SymbolData> b)
    {
        if (a.Count != b.Count) return false;

        var aSet = new HashSet<SymbolData>(a);
        var bSet = new HashSet<SymbolData>(b);

        return aSet.SetEquals(bSet);
    }
}
