using System;
using System.Collections.Generic;
using UnityEngine;

public class SymbolCombiner : MonoBehaviour
{
    [Header("Base de datos de combinaciones")]
    public List<SymbolCombinationData> allCombinations;

    /// <summary>
    /// Combina dos símbolos (por interfaz) y devuelve el resultado (SymbolData) si existe.
    /// </summary>
    public SymbolData Combine(ISymbol symbolA, ISymbol symbolB)
    {
        foreach (var combo in allCombinations)
        {
            // Comparación bidireccional: A+B o B+A
            bool isMatch =
                (combo.inputA.symbolName == symbolA.SymbolName && combo.inputB.symbolName == symbolB.SymbolName) ||
                (combo.inputA.symbolName == symbolB.SymbolName && combo.inputB.symbolName == symbolA.SymbolName);

            if (isMatch)
            {
                Debug.Log($"¡Combinación encontrada! {symbolA.SymbolName} + {symbolB.SymbolName} = {combo.result.symbolName}");
                return combo.result;
            }
        }

        Debug.LogWarning($"No se encontró combinación para {symbolA.SymbolName} + {symbolB.SymbolName}");
        return null;
    }

    internal SymbolData Combine(SymbolData symbolA, SymbolData symbolB)
    {
        throw new NotImplementedException();
    }
}
