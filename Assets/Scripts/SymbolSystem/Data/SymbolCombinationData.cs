using UnityEngine;

[CreateAssetMenu(menuName = "Symbols/Combination")]
public class SymbolCombinationData : ScriptableObject
{
    public SymbolData inputA;
    public SymbolData inputB;
    public SymbolData result;
}
