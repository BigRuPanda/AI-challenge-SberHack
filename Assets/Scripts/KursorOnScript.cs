using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KursorOn : MonoBehaviour
{
    public static bool s_KursorOn = false;

    private void OnMouseDown()
    {
        s_KursorOn = !s_KursorOn;

        if (s_KursorOn) gameObject.GetComponent<Renderer>().material.SetColor("_Color", new Color(0.2f, 0.4f, 0.2f, 1.0f));
        else gameObject.GetComponent<Renderer>().material.SetColor("_Color", new Color(0.4f, 0.2f, 0.2f, 1.0f));
    }
}
