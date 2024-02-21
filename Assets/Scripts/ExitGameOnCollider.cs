using UnityEngine;

public class ExitGameOnCollider : MonoBehaviour
{
    private void OnMouseDown()
    {
        Application.Quit();
    }
}
