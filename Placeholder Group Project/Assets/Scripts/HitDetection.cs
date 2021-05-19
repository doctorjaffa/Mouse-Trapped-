using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HitDetection : MonoBehaviour
{
    public int health;
    public TextMeshProUGUI displayHealth;

    // Start is called before the first frame update
    void Start()
    {
        health = 0;
        SetDisplayHealth();
    }

    // Update is called once per frame
    void Update()
    {
        displayHealth.text = health.ToString();

        Rigidbody2D characterRigidbody = GetComponent<Rigidbody2D>();
        Collider2D characterCollider = GetComponent<Collider2D>();
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            health = health - 1;
            SetDisplayHealth();
        }
    }

    void SetDisplayHealth()
    {
        displayHealth.text = "Health: " + health.ToString();

        if (health == 0)
        {
            displayHealth.text = "You lose.";
        }
    }
}
