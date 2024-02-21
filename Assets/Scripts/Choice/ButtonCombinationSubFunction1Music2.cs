using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCombinationSubFunction1Music2 : MonoBehaviour
{
    public ButtonCombinationForMusic buttonCombinationForMusic;

    public void OnMouseDown()
    {
        buttonCombinationForMusic.Function2();
    }
}
