using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera2Controller : MonoBehaviour
{
    public Transform cam1;
    public Transform cam2;
    

    // Update is called once per frame
    void Update()
    {
        cam2.transform.rotation = cam1.transform.localRotation;

    }
}
