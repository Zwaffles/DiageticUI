using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class cloic : MonoBehaviour
{
    public GameObject canvas;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            Destroy(canvas);
        }
    }

}
