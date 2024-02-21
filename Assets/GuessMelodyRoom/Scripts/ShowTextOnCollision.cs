using UnityEngine;
using TMPro;

public class ShowTextOnMouseDown : MonoBehaviour
{
    public TextMeshPro text1;
    public TextMeshPro text2; 
    public Transform player, destination;
    public GameObject playerObj;
    public GameObject darkOverlay;

    private void Start()
    {
        // Изначально скрываем все текстовые объекты
        text1.gameObject.SetActive(false);
        text2.gameObject.SetActive(false);
    }

    private void OnMouseDown()
    {
        // Проверяем, касается ли игрок этого объекта
        if (gameObject.CompareTag("Object1"))
        {
            text1.gameObject.SetActive(true);
            text2.gameObject.SetActive(false);
            StartCoroutine(TeleportPlayerAfterDelay(5f));

        }
        else if (gameObject.CompareTag("Object2"))
        {
            text1.gameObject.SetActive(false);
            text2.gameObject.SetActive(true);

        }
        else if (gameObject.CompareTag("Object3"))
        {
            text1.gameObject.SetActive(false);
            text2.gameObject.SetActive(true);
        }
    }


    private System.Collections.IEnumerator TeleportPlayerAfterDelay(float delay)
    {
        destination.transform.parent.gameObject.SetActive(true);
        Debug.Log("Запуск TeleportPlayerAfterDelay");
        yield return new WaitForSeconds(delay);
        {
                playerObj.SetActive(false);
                player.position = destination.position;
                transform.parent.transform.parent.gameObject.SetActive(false);
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