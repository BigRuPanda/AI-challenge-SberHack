using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static PlayerTeleportOnClick;

public class DictorScript : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.transform.Find("Dictor").transform.Find("Room1").gameObject.SetActive(false);
            other.transform.Find("Dictor").transform.Find("Room2").gameObject.SetActive(false);
            other.transform.Find("Dictor").transform.Find("Room3").gameObject.SetActive(false);
            other.transform.Find("Dictor").transform.Find("Room4").gameObject.SetActive(false);
            other.transform.Find("Dictor").transform.Find("Room5").gameObject.SetActive(false);
            other.transform.Find("Dictor").transform.Find("RoomMelody").gameObject.SetActive(false);
            other.transform.Find("Dictor").transform.Find("RoomXO").gameObject.SetActive(false);
            other.transform.Find("Dictor").transform.Find("RoomLabirint").gameObject.SetActive(false);
            other.transform.Find("Dictor").transform.Find("FinalRoomPicture").gameObject.SetActive(false);
            other.transform.Find("Dictor").transform.Find("FinalRoomElement").gameObject.SetActive(false);
            other.transform.Find("Dictor").transform.Find("FinalRoomProza").gameObject.SetActive(false);
            other.transform.Find("Dictor").transform.Find("FinalRoomMusic 1").gameObject.SetActive(false);

            if (this.tag == "Room1")
            {
                other.transform.Find("Dictor").transform.Find("Room1").gameObject.SetActive(true);
            }
            else if (this.tag == "Room2")
            {
                other.transform.Find("Dictor").transform.Find("Room2").gameObject.SetActive(true);
            }
            else if (this.tag == "Room3")
            {
                other.transform.Find("Dictor").transform.Find("Room3").gameObject.SetActive(true);
            }
            else if (this.tag == "Room4")
            {
                other.transform.Find("Dictor").transform.Find("Room4").gameObject.SetActive(true);
            }

            else if (this.tag == "Room5")
            {
                other.transform.Find("Dictor").transform.Find("Room5").gameObject.SetActive(true);

                if (transform.Find("Pictures").transform.Find("Picture").transform.Find("FinalPicture").transform.Find("FinalPicture1").gameObject.activeSelf == true)
                {
                    other.transform.Find("Dictor").transform.Find("Room5").transform.Find("Comp").gameObject.SetActive(true);
                }

                if (transform.Find("Pictures").transform.Find("Picture").transform.Find("FinalPicture").transform.Find("FinalPicture2").gameObject.activeSelf == true)
                {
                    other.transform.Find("Dictor").transform.Find("Room5").transform.Find("Himi").gameObject.SetActive(true);
                }
                if (transform.Find("Pictures").transform.Find("Picture").transform.Find("FinalPicture").transform.Find("FinalPicture3").gameObject.activeSelf == true)
                {
                    other.transform.Find("Dictor").transform.Find("Room5").transform.Find("Hudo").gameObject.SetActive(true);
                }
                if (transform.Find("Pictures").transform.Find("Picture").transform.Find("FinalPicture").transform.Find("FinalPicture4").gameObject.activeSelf == true)
                {
                    other.transform.Find("Dictor").transform.Find("Room5").transform.Find("Auth").gameObject.SetActive(true);
                }
            }

            else if (gameObject.name == "MelodyRoom")
            {
                other.transform.Find("Dictor").transform.Find("RoomMelody").gameObject.SetActive(true);
            }
            else if (gameObject.name == "XORoom")
            {
                other.transform.Find("Dictor").transform.Find("RoomXO").gameObject.SetActive(true);
            }
            else if (gameObject.name == "LabirintRoom")
            {
                other.transform.Find("Dictor").transform.Find("RoomLabirint").gameObject.SetActive(true);
            }

            else if (gameObject.name == "FinalRoomHudozh")
            {
                other.transform.Find("Dictor").transform.Find("FinalRoomPicture").gameObject.SetActive(true);
            }
            else if (gameObject.name == "FinalRoomElem")
            {
                other.transform.Find("Dictor").transform.Find("FinalRoomElement").gameObject.SetActive(true);
            }
            else if (gameObject.name == "FinalRoomPoet")
            {
                other.transform.Find("Dictor").transform.Find("FinalRoomProza").gameObject.SetActive(true);
            }
            else if (gameObject.name == "FinalRoomMusicant")
            {
                other.transform.Find("Dictor").transform.Find("FinalRoomMusic 1").gameObject.SetActive(true);
            }

            if (gameObject.name == "ParkourRoom")
            {
                if (other.transform.Find("Dictor").transform.Find("RoomParkour").gameObject.activeSelf == false)
                {
                    other.transform.Find("Dictor").transform.Find("RoomParkour").gameObject.SetActive(true);
                    other.transform.Find("Dictor").transform.Find("RoomParkour").GetComponent<AudioSource>().Play();
                }
            }
            else
                other.transform.Find("Dictor").transform.Find("RoomParkour").gameObject.SetActive(false);
        }
    }
}
