using UnityEngine;

public class ColliderActivation : MonoBehaviour
{
    public GameObject[] objectsToActivate;
    public Collider[] colliders;

    private void Start()
    {
        DeactivateAllObjects();
    }

    private void OnMouseDown()
    {
        for (int i = 0; i < colliders.Length; i++)
        {
            if (colliders[i] == gameObject.GetComponent<Collider>())
            {
                ActivateObject(i);
            }
            else
            {
                DeactivateObject(i);
            }
        }
    }

    private void ActivateObject(int index)
    {
        if (index >= 0 && index < objectsToActivate.Length)
        {
            objectsToActivate[index].SetActive(true);
        }
    }

    private void DeactivateObject(int index)
    {
        if (index >= 0 && index < objectsToActivate.Length)
        {
            objectsToActivate[index].SetActive(false);
        }
    }

    private void DeactivateAllObjects()
    {
        foreach (var obj in objectsToActivate)
        {
            obj.SetActive(false);
        }
    }
}
