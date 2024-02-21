using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class KursorViewScript : MonoBehaviour
{

    private void Update()
    {
        transform.Find("Kursor").gameObject.SetActive(KursorOn.s_KursorOn);
    }

}
