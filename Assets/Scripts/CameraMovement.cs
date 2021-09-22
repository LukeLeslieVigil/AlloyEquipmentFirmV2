using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject player;

    void LateUpdate()
    {
        var XPosition = player.transform.position.x;
        var ZPosition = player.transform.position.z;

        transform.position = new Vector3(XPosition, transform.position.y, ZPosition);
    }
}
