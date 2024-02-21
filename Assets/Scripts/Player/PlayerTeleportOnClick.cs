using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerTeleportOnClick : MonoBehaviour
{
    public static int ComposerCount = 0;
    public static int ScientistCount = 0;
    public static int PainterCount = 0;
    public static int AuthorCount = 0;
    public Transform Destination;
    private GameObject playerObj;
    public GameObject FinalPicture1;
    public GameObject FinalPicture2;
    public GameObject FinalPicture3;
    public GameObject FinalPicture4;
    public GameObject FinalSign1;
    public GameObject FinalSign2;
    public GameObject FinalSign3;
    public GameObject FinalSign4;
    public GameObject Room1;
    public GameObject Room2;
    public GameObject Room3;
    public GameObject Room4;
    public GameObject Room5;
    public GameObject Lab;
    public GameObject Par;
    public GameObject Mel;
    public GameObject XO;
    public GameObject Fpi;
    public GameObject Fel;
    public GameObject Fmusic;
    public GameObject Fcomp;
    public GameObject darkOverlay;

    private void Awake()
    {
        playerObj = GameObject.FindGameObjectWithTag("Player");

        if (playerObj == null)
        {
            Debug.LogError("Игрок не найден. Убедитесь, что у игрока установлен тег 'Player'");
        }
        FinalPicture1 = GameObject.Find("FinalPicture1");
        FinalPicture2 = GameObject.Find("FinalPicture2");
        FinalPicture3 = GameObject.Find("FinalPicture3");
        FinalPicture4 = GameObject.Find("FinalPicture4");
        FinalSign1 = GameObject.Find("FinalSign1");
        FinalSign2 = GameObject.Find("FinalSign2");
        FinalSign3 = GameObject.Find("FinalSign3");
        FinalSign4 = GameObject.Find("FinalSign4");
        Room1 = GameObject.Find("LuxuryRoom1");
        Room2 = GameObject.Find("LuxuryRoom2");
        Room3 = GameObject.Find("LuxuryRoom3");
        Room4 = GameObject.Find("LuxuryRoom4");
        Room5 = GameObject.Find("LuxuryRoom5");
        Lab = GameObject.Find("LabirintRoom");
        Par = GameObject.Find("ParkourRoom");
        Mel = GameObject.Find("MelodyRoom");
        XO = GameObject.Find("XORoom");
        Fpi = GameObject.Find("FinalRoomHudozh");
        Fel = GameObject.Find("FinalRoomElem");
        Fmusic = GameObject.Find("FinalRoomMusicant");
        Fcomp = GameObject.Find("FinalRoomPoet");
    }

    private void Start()
    {
        if (this.transform.parent.transform.parent.gameObject.name == "LuxuryRoom1")
        {
            Room2.gameObject.SetActive(false);
            Room3.gameObject.SetActive(false);
            Room4.gameObject.SetActive(false);
            Room5.gameObject.SetActive(false);
            Lab.gameObject.SetActive(false); 
            Par.gameObject.SetActive(false);
            Mel.gameObject.SetActive(false);
            XO.gameObject.SetActive(false);
            FinalPicture1.gameObject.SetActive(false);
            FinalPicture2.gameObject.SetActive(false);
            FinalPicture3.gameObject.SetActive(false);
            FinalPicture4.gameObject.SetActive(false);
            FinalSign1.gameObject.SetActive(false);
            FinalSign2.gameObject.SetActive(false);
            FinalSign3.gameObject.SetActive(false);
            FinalSign4.gameObject.SetActive(false);
            Fpi.gameObject.SetActive(false);
            Fel.gameObject.SetActive(false);
            Fmusic.gameObject.SetActive(false);
            Fcomp.gameObject.SetActive(false);
            ComposerCount = 0;
            ScientistCount = 0;
            PainterCount = 0;
            AuthorCount = 0;
            darkOverlay.SetActive(false);
        }
    }

    private void OnMouseDown()
    {
        ChoiceCount(this.gameObject);
        StartCoroutine(ActivateObjectForHalfSecond());
        TeleportPlayer();


        if (Destination.gameObject.name == "TeleportZone5")
        {
            if (ComposerCount > ScientistCount &&
                ComposerCount > PainterCount &&
                ComposerCount > AuthorCount)
            {
                FinalPicture1.gameObject.SetActive(true);
                FinalSign1.gameObject.SetActive(true);
                FinalPicture2.gameObject.SetActive(false);
                FinalSign2.gameObject.SetActive(false);
                FinalPicture3.gameObject.SetActive(false);
                FinalSign3.gameObject.SetActive(false);
                FinalPicture4.gameObject.SetActive(false);
                FinalSign4.gameObject.SetActive(false);
            }

            if (ScientistCount > ComposerCount &&
                ScientistCount > PainterCount &&
                ScientistCount > AuthorCount)
            {
                FinalPicture2.gameObject.SetActive(true);
                FinalSign2.gameObject.SetActive(true);
                FinalPicture1.gameObject.SetActive(false);
                FinalSign1.gameObject.SetActive(false);
                FinalPicture3.gameObject.SetActive(false);
                FinalSign3.gameObject.SetActive(false);
                FinalPicture4.gameObject.SetActive(false);
                FinalSign4.gameObject.SetActive(false);
            }

            if (PainterCount > ComposerCount &&
                PainterCount > ScientistCount &&
                PainterCount > AuthorCount)
            {
                FinalPicture3.gameObject.SetActive(true);
                FinalSign3.gameObject.SetActive(true);
                FinalPicture2.gameObject.SetActive(false);
                FinalSign2.gameObject.SetActive(false);
                FinalPicture1.gameObject.SetActive(false);
                FinalSign1.gameObject.SetActive(false);
                FinalPicture4.gameObject.SetActive(false);
                FinalSign4.gameObject.SetActive(false);
            }

            if (AuthorCount > ScientistCount &&
                AuthorCount > PainterCount &&
                AuthorCount > ComposerCount)
            {
                FinalPicture4.gameObject.SetActive(true);
                FinalSign4.gameObject.SetActive(true);
                FinalPicture2.gameObject.SetActive(false);
                FinalSign2.gameObject.SetActive(false);
                FinalPicture3.gameObject.SetActive(false);
                FinalSign3.gameObject.SetActive(false);
                FinalPicture1.gameObject.SetActive(false);
                FinalSign1.gameObject.SetActive(false);
            }
        }

        IEnumerator ActivateObjectForHalfSecond()
        {
            // Активируем объект
            darkOverlay.SetActive(true);

            // Ждем 0.5 секунды
            yield return new WaitForSeconds(0.5f);

            // Деактивируем объект
            darkOverlay.SetActive(false);
        }
    }

    public void TeleportPlayer()
    {
        if (playerObj != null && Destination != null)
        {
            if (this.transform.parent.transform.parent.gameObject.name == "LuxuryRoom1") 
            {
                Room2.gameObject.SetActive(true);
            }

            else if (this.transform.parent.transform.parent.gameObject.name == "LuxuryRoom2")
            {
                Room3.gameObject.SetActive(true);
            }

            else if (this.transform.parent.transform.parent.gameObject.name == "LuxuryRoom3")
            {
                Room4.gameObject.SetActive(true);
            }

            else if (this.transform.parent.transform.parent.gameObject.name == "LuxuryRoom4")
            {
                Room5.gameObject.SetActive(true);
            }

            playerObj.SetActive(false);
            this.transform.parent.transform.parent.gameObject.SetActive(false);
            playerObj.transform.position = Destination.position;
            playerObj.SetActive(true);
        }
    }

    public void ChoiceCount(GameObject paint)
    {
        if (paint.name == "Picture1-1")
        {
            ComposerCount+=4;
        }

        else if (paint.name == "Picture1-2")
        {
            ScientistCount+=4;
        }

        else if (paint.name == "Picture1-3")
        {
            PainterCount+=4;
        }

        else if(paint.name == "Picture2-1")
        {
            PainterCount+=4;
        }

        else if (paint.name == "Picture2-2")
        {
            ScientistCount+=4;
        }

        else if (paint.name == "Picture2-3")
        {
            AuthorCount+=4;
        }

        else if(paint.name == "Picture3-1")
        {
            ComposerCount+=4;
        }

        else if (paint.name == "Picture3-2")
        {
            PainterCount+=5;
        }

        else if (paint.name == "Picture3-3")
        {
            AuthorCount+=4;
        }

        else if (paint.name == "Picture4-1")
        {
            ComposerCount += 6;
        }

        else if (paint.name == "Picture4-2")
        {
            AuthorCount += 6;
        }

        else if (paint.name == "Picture4-3")
        {
            ScientistCount += 6;
        }
/*
        Debug.Log(ComposerCount);
        Debug.Log(ScientistCount);
        Debug.Log(PainterCount);
        Debug.Log(AuthorCount);
*/
    }
}
