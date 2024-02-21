using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTeleport : MonoBehaviour
{
    public Transform player, destination;
    public GameObject playerObj;
    private Transform parentObj;
    public GameObject darkOverlay;


    void OnTriggerEnter(Collider other)
    {
        destination.transform.parent.gameObject.SetActive(true);
        StartCoroutine(ActivateObjectForHalfSecond());
        if (other.CompareTag("Player"))
        {
            parentObj = transform;

            playerObj.SetActive(false);

            for (int i = 0; i < 5; i++)
            {
                if (parentObj.gameObject.name == "LabirintRoom" ||
                    parentObj.gameObject.name == "ParkourRoom")
                {
                    parentObj.gameObject.SetActive(false);
                    break;
                }
                else
                {
                    if (parentObj.gameObject.name == "Teleport")
                        break;
                    parentObj = parentObj.transform.parent;
                }
            }

            player.position = destination.position;
            playerObj.SetActive(true);
        }     
    }

    private System.Collections.IEnumerator ActivateObjectForHalfSecond()
        {
            // Активируем объект
            darkOverlay.SetActive(true);

            // Ждем 0.5 секунды
            yield return new WaitForSeconds(0.5f);

            // Деактивируем объект
            darkOverlay.SetActive(false);
        }
}
