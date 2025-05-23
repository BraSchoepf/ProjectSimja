using System.Collections.Generic;
using UnityEngine;

public class SymbolCombiner : MonoBehaviour 
{
    public List<ISymbol> selectedSymbols = new();

    public void TryCombineSelected()
    {
        if (selectedSymbols.Count == 2)
        {
            ISymbol result = selectedSymbols[0].Combine(selectedSymbols[1]);

            if (result != null)
            {
                Debug.Log("¡Creaste:" + result.SymbolName + "!");

            }
            else
            {
                Debug.Log("Combinación inválida");
            }

            selectedSymbols.Clear();
        }
    }
}
