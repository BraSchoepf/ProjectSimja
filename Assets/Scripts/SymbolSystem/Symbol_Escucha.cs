using System.Collections.Generic;
using UnityEngine;

    public class Symbol_Escucha : SymbolBase
    {
        public override string SymbolName => "Escucha";
        public override Sprite SymbolIcon => null; // o tu sprite cargado

        public override List<string> CombinableWith()
        {
            return new List<string> { "Interpretación Semántica", "Silencio", "Interpretación Práctica" };
        }
    }


