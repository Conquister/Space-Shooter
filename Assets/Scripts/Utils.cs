using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Utils{

    public static Vector2 GetDimensionsInWorldUnits(){
        float width, height;
        Camera cam = Camera.main;

        height = cam.orthographicSize * 2;
        float ratio = cam.pixelWidth / (float)cam.pixelHeight;
        width = height * ratio;

        return new Vector2(width,height);
    }
}
