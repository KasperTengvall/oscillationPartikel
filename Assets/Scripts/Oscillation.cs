using System;
using UnityEngine;

public class Oscillation : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    Vector3 Position;
    void Start()
    {
        Position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Position.y = Mathf.Sin(Time.time + transform.position.z);

        transform.position = Position;
    }
}
