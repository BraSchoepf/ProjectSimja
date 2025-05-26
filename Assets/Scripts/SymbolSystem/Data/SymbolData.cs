using UnityEngine;

[CreateAssetMenu(menuName = "Symbols/Symbol")]
public class SymbolData : ScriptableObject
{
    public string symbolName;
    public Sprite icon;
    public GameObject prefaps;
}
