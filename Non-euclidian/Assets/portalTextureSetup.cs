﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portalTextureSetup : MonoBehaviour
{
    public Camera cameraB;
    public Material cameraBMat;

    // Start is called before the first frame update
    void Start()
    {
        if (cameraB.targetTexture != null){

            cameraB.targetTexture.Release();
        }

        cameraB.targetTexture = new RenderTexture (Screen.width, Screen.height, 24 );
        cameraBMat.mainTexture = cameraB.targetTexture;
    }

    
}
