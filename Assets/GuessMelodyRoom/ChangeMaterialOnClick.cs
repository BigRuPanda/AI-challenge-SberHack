using UnityEngine;

public class ChangeMaterialOnClick : MonoBehaviour
{
    public Material newMaterial;
    private Material originalMaterial;
    private Renderer objectRenderer;

    private void Start()
    {
        objectRenderer = GetComponent<Renderer>();
        originalMaterial = objectRenderer.material;
    }

    private void OnMouseDown()
    {
        objectRenderer.material = newMaterial;
    }
}
