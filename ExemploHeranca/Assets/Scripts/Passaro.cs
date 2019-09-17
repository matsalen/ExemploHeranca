using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Passaro : Animal
{
    protected override void Fala()
    {
        Debug.Log("Piu piu");
    }

    protected override void Pula()
    {
        velocidadeVertical = 10f;
    }
}
