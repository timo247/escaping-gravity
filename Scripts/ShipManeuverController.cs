﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipManeuverController : MonoBehaviour
{
    private Rigidbody2D rb;
    float maxVelocity = 2;

    public float rotationSpeed = 1;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float yAxis = Input.GetAxis("Vertical");
        float xAxis = Input.GetAxis("Horizontal");

        ThrustForward(yAxis);
        Rotate(transform, xAxis * -rotationSpeed);



    }

    #region ManeuvringAPI

    private void ClampVelocity()
    {
        float x = Mathf.Clamp(rb.velocity.x, -maxVelocity, maxVelocity);
        float y = Mathf.Clamp(rb.velocity.y, -maxVelocity, maxVelocity);

        rb.velocity = new Vector2(x, y);

    }

    private void ThrustForward(float amount)
    {
        Vector2 force = transform.up * amount;
        rb.AddForce(force);

    }


    private void Rotate(Transform t, float amount)
    {
        t.Rotate(0, 0, amount);
    }


    #endregion

}
