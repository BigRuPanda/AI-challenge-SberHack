using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader2 : MonoBehaviour
{
    // Название сцены, в которую нужно переместить игрока
    public string targetSceneName;
    public Vector3 targetPosition;
    public PlayerTeleportOnClick playerTeleportOnClick;
    public GameObject darkOverlay;


    private void Start()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
        playerTeleportOnClick = GameObject.FindObjectOfType<PlayerTeleportOnClick>();
    }

    private void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == targetSceneName)
        
        {
            GameObject player = GameObject.FindGameObjectWithTag("Player");

            if (player != null)
            {
                player.transform.position = targetPosition;
            }
        }
    }

    private void OnMouseDown()
    {
        SceneManager.LoadScene(targetSceneName);
        StartCoroutine(ActivateObjectForHalfSecond());
        // playerTeleportOnClick.ComposerCount = 0;
        // playerTeleportOnClick.ScientistCount = 0;
        // playerTeleportOnClick.PainterCount = 0;
        // playerTeleportOnClick.AuthorCount = 0;
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
