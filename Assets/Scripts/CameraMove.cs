using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform player;
    public float SpeedFollow = 5;
    private Vector3 offset;
    void Start()
    {
        offset = player.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset; 
    }
}
