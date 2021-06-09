using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoMovement : MonoBehaviour
{
    public Vector3 MovementPerFrame;
    public float Speed = 0.25f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start function has run!");
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("Update has run!");

        transform.position = transform.position + MovementPerFrame * Speed;
    }
}
