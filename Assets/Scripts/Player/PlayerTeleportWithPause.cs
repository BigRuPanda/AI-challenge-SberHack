using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerTeleportWithPause : MonoBehaviour
{
    public Transform Destination;
    private GameObject playerObj;
    public GameObject darkOverlay;

    private void Awake()
    {
        playerObj = GameObject.FindGameObjectWithTag("Player");

        if (playerObj == null)
        {
            Debug.LogError("Игрок не найден. Убедитесь, что у игрока установлен тег 'Player'");
        }
    }

    private void OnEnable()
    {
        Destination.transform.parent.gameObject.SetActive(true);
        StartCoroutine(TeleportPlayerAfterDelay(45f));
    }

    private System.Collections.IEnumerator TeleportPlayerAfterDelay(float delay)
    {
        Debug.Log("Запуск TeleportPlayerAfterDelay");

        yield return new WaitForSeconds(delay);
        {
            playerObj.SetActive(false);
            transform.parent.transform.parent.transform.parent.transform.parent.gameObject.SetActive(false);
            playerObj.transform.position = Destination.position;
            playerObj.SetActive(true);
            StartCoroutine(ActivateObjectForHalfSecond());
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