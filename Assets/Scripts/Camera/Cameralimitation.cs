using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameralimitation : MonoBehaviour
{
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    // «десь мы определ€ем границы перемещени€ камеры
    void LateUpdate()
    {
        Vector3 position = transform.position;
        position.x = Mathf.Clamp(position.x, minX, maxX);
        position.y = Mathf.Clamp(position.y, minY, maxY);
        transform.position = position;
    }
}