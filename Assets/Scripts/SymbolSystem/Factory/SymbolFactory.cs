using System.Collections.Generic;
using UnityEngine;
using System;

public class SymbolFactory : MonoBehaviour 
{
    public SymbolData[] allSymbol;

    public GameObject CreateSymbol(SymbolData data, Vector2 position)
    {
        if (data.prefaps == null)
        {
            Debug.LogError($"No prefab definido para el símbolo {data.symbolName}");
            return null;
        }

        var instance = Instantiate(data.prefaps, position, Quaternion.identity);
        var baseSymbol = instance.GetComponent<SymbolBase>();
        if (baseSymbol != null)
        {
            baseSymbol.Initialize(data);
        }
        return instance;
    }

}
