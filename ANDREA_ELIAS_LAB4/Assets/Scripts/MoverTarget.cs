using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverTarget : MonoBehaviour
{

    public float delta = 1.5f;  
    public float speed = 2.0f;
    private Vector3 Inicio;

    void Start()
    {
        Inicio = transform.position;
    }

    void FixedUpdate()
    {
        Vector3 v = Inicio;
        v.x += delta * Mathf.Sin(Time.time * speed);
        transform.position = v;
    }
}
