using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    //ESTE SCRIPT CONTROLA EL MOVIMIENTO DEL JUGADOR

    private Rigidbody2D rb;

    [SerializeField]
    [Range(1f, 5f)]
    float ySensitivity;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float v = Input.GetAxis("Vertical");
        rb.velocity = Vector2.up * v * (ySensitivity * 100f) * Time.deltaTime;
    }
}