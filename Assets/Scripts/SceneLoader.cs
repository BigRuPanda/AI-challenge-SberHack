using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Название сцены, в которую нужно переместить игрока
    public string targetSceneName;

    // Координаты, в которые нужно переместить игрока в новой сцене
    public Vector3 targetPosition;
    public GameObject darkOverlay;

    private void OnMouseDown()
    {
        SceneManager.LoadScene(targetSceneName);
        StartCoroutine(ActivateObjectForHalfSecond());
    }

    // Вызывается после загрузки новой сцены
    private void OnLevelWasLoaded(int level)
    {
        // Поиск игрока и камеры в новой сцене
        GameObject player = GameObject.FindGameObjectWithTag("Player");

        // Перемещение игрока и камеры на указанные координаты
        if (player != null)
        {
            player.transform.position = targetPosition;
            StartCoroutine(ActivateObjectForHalfSecond());
        }

    }
    private System.Collections.IEnumerator ActivateObjectForHalfSecond()
        {
            yield return new WaitForSeconds(1f);
            darkOverlay.SetActive(true);

            // Ждем 0.5 секунды

            // Деактивируем объект
            darkOverlay.SetActive(false);
        }
}
