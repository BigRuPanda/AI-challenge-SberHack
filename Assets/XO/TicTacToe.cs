using UnityEngine;
using TMPro;
using System.Collections.Generic;

public class TicTacToe : MonoBehaviour
{
    public GameObject[] cells; // Массив объектов для клеток
    public GameObject xPrefab; // Префаб крестика
    public GameObject oPrefab; // Префаб нолика
    public TextMeshProUGUI gameOverText; // GameObject для отображения результата игры
    public Transform player, destination;
    public GameObject playerObj;
    private bool gameRestarting = false; // Флаг, указывающий на то, что игра перезапускается
    private bool playerX = true; // Очередь игрока X
    private bool gameOver = false; // Флаг, указывающий на завершение игры
    public GameObject darkOverlay;

    private void Update()
{
    if (!gameOver)
    {
        if (playerX)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit))
                {
                    GameObject cellObject = hit.transform.gameObject;

                    if (cellObject != null && cellObject.tag == "Cell" && cellObject.transform.childCount == 0)
                    {
                        GameObject symbol = Instantiate(xPrefab, cellObject.transform.position, Quaternion.Euler(0, 270, 45));
                        symbol.transform.SetParent(cellObject.transform);


                        if (CheckForWin())
                        {
                            return;
                        }

                        playerX = false;
                        if (!gameOver)
                        {
                            ComputerMove();
                        }
                    }
                }
            }
        }
    }
}

private bool CheckForWin()
{
    for (int i = 0; i < 3; i++)
    {
        if (cells[i * 3].transform.childCount > 0 &&
            cells[i * 3].transform.GetChild(0).CompareTag("X") &&
            cells[i * 3 + 1].transform.childCount > 0 &&
            cells[i * 3 + 1].transform.GetChild(0).CompareTag("X") &&
            cells[i * 3 + 2].transform.childCount > 0 &&
            cells[i * 3 + 2].transform.GetChild(0).CompareTag("X"))
        {
            ShowWinMessage("X");
            return true;
        }
        else if (cells[i * 3].transform.childCount > 0 &&
            cells[i * 3].transform.GetChild(0).CompareTag("O") &&
            cells[i * 3 + 1].transform.childCount > 0 &&
            cells[i * 3 + 1].transform.GetChild(0).CompareTag("O") &&
            cells[i * 3 + 2].transform.childCount > 0 &&
            cells[i * 3 + 2].transform.GetChild(0).CompareTag("O"))
        {
            ShowWinMessage("O");
            return true;
        }

        if (cells[i].transform.childCount > 0 &&
            cells[i].transform.GetChild(0).CompareTag("X") &&
            cells[i + 3].transform.childCount > 0 &&
            cells[i + 3].transform.GetChild(0).CompareTag("X") &&
            cells[i + 6].transform.childCount > 0 &&
            cells[i + 6].transform.GetChild(0).CompareTag("X"))
        {
            ShowWinMessage("X");
            return true;
        }
        else if (cells[i].transform.childCount > 0 &&
            cells[i].transform.GetChild(0).CompareTag("O") &&
            cells[i + 3].transform.childCount > 0 &&
            cells[i + 3].transform.GetChild(0).CompareTag("O") &&
            cells[i + 6].transform.childCount > 0 &&
            cells[i + 6].transform.GetChild(0).CompareTag("O"))
        {
            ShowWinMessage("O");
            return true;
        }
    }

    if ((cells[0].transform.childCount > 0 &&
            cells[0].transform.GetChild(0).CompareTag("X") &&
            cells[4].transform.childCount > 0 &&
            cells[4].transform.GetChild(0).CompareTag("X") &&
            cells[8].transform.childCount > 0 &&
            cells[8].transform.GetChild(0).CompareTag("X")) ||
        (cells[2].transform.childCount > 0 &&
            cells[2].transform.GetChild(0).CompareTag("X") &&
            cells[4].transform.childCount > 0 &&
            cells[4].transform.GetChild(0).CompareTag("X") &&
            cells[6].transform.childCount > 0 &&
            cells[6].transform.GetChild(0).CompareTag("X")))
    {
        ShowWinMessage("X");
        return true;
    }
    else if ((cells[0].transform.childCount > 0 &&
            cells[0].transform.GetChild(0).CompareTag("O") &&
            cells[4].transform.childCount > 0 &&
            cells[4].transform.GetChild(0).CompareTag("O") &&
            cells[8].transform.childCount > 0 &&
            cells[8].transform.GetChild(0).CompareTag("O")) ||
        (cells[2].transform.childCount > 0 &&
            cells[2].transform.GetChild(0).CompareTag("O") &&
            cells[4].transform.childCount > 0 &&
            cells[4].transform.GetChild(0).CompareTag("O") &&
            cells[6].transform.childCount > 0 &&
            cells[6].transform.GetChild(0).CompareTag("O")))
    {
        ShowWinMessage("O");
        return true;
    }
    bool draw = true;
    foreach (GameObject cell in cells)
    {
        if (cell.transform.childCount == 0)
        {
            draw = false;
            break;
        }
    }

    if (draw)
    {
        ShowDrawMessage();
        return true;
    }

    return false;
}


private void ComputerMove()
{
    List<GameObject> emptyCells = new List<GameObject>();

    foreach (GameObject cell in cells)
    {
        if (cell.transform.childCount == 0)
        {
            emptyCells.Add(cell);
        }
    }

    if (emptyCells.Count > 0)
    {
        int randomIndex = Random.Range(0, emptyCells.Count);
        GameObject randomCell = emptyCells[randomIndex];
        GameObject symbol = Instantiate(oPrefab, randomCell.transform.position, Quaternion.Euler(0, 270, 0));
        symbol.transform.SetParent(randomCell.transform);
        playerX = true;

        CheckForWin();
    }
}

    private bool IsBoardFull()
    {
        foreach (GameObject cell in cells)
        {
            if (cell.transform.childCount == 0)
            {
                return false;
            }
        }
        return true;
    }

    private void ShowWinMessage(string winner)
    {
        gameOver = true;
        gameOverText.gameObject.SetActive(true);
        gameOverText.text = "Победили: " + winner + "-ки";

        if (winner == "O")
        {
            StartCoroutine(RestartGameAfterDelay(3f));
        }
        else
        {
            StartCoroutine(TeleportPlayerAfterDelay(5f));
        }
    }


    private void ShowDrawMessage()
    {
        gameOver = true;
        gameOverText.gameObject.SetActive(true);
        gameOverText.text = "Ничья";
        StartCoroutine(RestartGameAfterDelay(3f));
    }


    private System.Collections.IEnumerator TeleportPlayerAfterDelay(float delay)
    {   
        destination.transform.parent.gameObject.SetActive(true);
        Debug.Log("Запуск TeleportPlayerAfterDelay");
        yield return new WaitForSeconds(delay);
        {
            playerObj.SetActive(false);
            transform.parent.gameObject.SetActive(false);
            player.position = destination.position;
            playerObj.SetActive(true);
            StartCoroutine(ActivateObjectForHalfSecond());
        }
    }

    private System.Collections.IEnumerator RestartGameAfterDelay(float delay)
    {
        gameRestarting = true;
        yield return new WaitForSeconds(delay);

        foreach (GameObject cell in cells)
        {
            if (cell.transform.childCount > 0)
            {
                Destroy(cell.transform.GetChild(0).gameObject);
            }
        }

        gameOver = false;
        playerX = true;
        gameRestarting = false;
        gameOverText.gameObject.SetActive(false);
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
