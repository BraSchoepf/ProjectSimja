using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Symbols/MultiCombination")]
public class SymbolMultiCombinationData : ScriptableObject
{
    public List<SymbolData> inputs;
    public SymbolData result;
}

