using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float jumpForce = 1f;
    private Rigidbody2D rb;

    public GameObject GameOver;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            rb.velocity = Vector2.up * jumpForce;
        }
    }

    void OnCollisionEnter2D(Collision2D colider)
    {
        GameOver.SetActive(true);
        Time.timeScale = 0;
    }
}
