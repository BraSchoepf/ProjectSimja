using System.Collections.Generic;
using UnityEngine;
using System;

public class SymbolFactory
{

    private static Dictionary<string, Func<ISymbol>> symbolRegistry = new()
    {
        {"Escucha", () => new Symbol_Escucha() },
        {"Escucha Sublime", () => new Symbol_EscuchaSublime() }
    };

    public static ISymbol TryCombine(ISymbol a, ISymbol b)
    {
        string comboKey = GetComboKey(a.SymbolName, b.SymbolName);

        return comboKey switch
        {
            "Oir+Interpretación" or "Interpretación+Oir" => symbolRegistry["Escucha"](),
            "Escucha+Interp.Silencios+Interp.Semántica+Interp.Práctica" => symbolRegistry["Escucha Sublime"](),
            _ => null

        };
    }

    private static string GetComboKey(string a, string b)
    {
        return $"{a}+{b}";
    }


}
