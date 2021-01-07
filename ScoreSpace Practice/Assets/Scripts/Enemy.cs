using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Health health;
    private ScoreManager scoreManager;
    private void Start()
    {
        health = GetComponent<Health>();
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Rigidbody2D rb = other.collider.GetComponent<Rigidbody2D>();
        health.LoseHealth((int) rb.velocity.magnitude);
        scoreManager.IncreaseScore((int) rb.velocity.magnitude);
    }
}
