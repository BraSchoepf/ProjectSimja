using UnityEngine;

public class SymbolTestUI : MonoBehaviour
{
    public SymbolFactory factory;
    public SymbolCombiner combiner;

    [Header("Instancias de símbolos en escena")]
    public GameObject symbolAInstance;
    public GameObject symbolBInstance;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (symbolAInstance == null || symbolBInstance == null)
            {
                Debug.LogWarning("Faltan asignar las instancias de los símbolos A o B.");
                return;
            }

            ISymbol symbolA = symbolAInstance.GetComponent<ISymbol>();
            ISymbol symbolB = symbolBInstance.GetComponent<ISymbol>();

            if (symbolA != null && symbolB != null)
            {
                SymbolData result = combiner.Combine(symbolA, symbolB);
                if (result != null)
                {
                    Debug.Log($"¡Combinación exitosa! {symbolA.SymbolName} + {symbolB.SymbolName} = {result.symbolName}");
                    factory.CreateSymbol(result, new Vector3(0, 2, 0)); // Posición arbitraria
                }
                else
                {
                    Debug.Log($"No se encontró combinación para {symbolA.SymbolName} + {symbolB.SymbolName}");
                }
            }
            else
            {
                Debug.LogWarning("Uno de los objetos no tiene un componente que implemente ISymbol.");
            }
        }
    }
}

