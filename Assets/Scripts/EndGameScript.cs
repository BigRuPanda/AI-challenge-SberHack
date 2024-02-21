using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameScript : MonoBehaviour
{
    public void OnMouseDown()
    {
        Application.Quit();
        Debug.Log("Quited");
    }
}
