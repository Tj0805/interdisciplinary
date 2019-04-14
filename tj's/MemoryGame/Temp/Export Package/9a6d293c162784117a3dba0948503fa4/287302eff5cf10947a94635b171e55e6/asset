using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    private bool isPinned = false;

    public float speed = 20f;
    public Rigidbody2D rb;

    void Update()
    {
        //to check the phisics of the pin, if it colided if it moved
        if (!isPinned)
            rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Circle")
        {
            //to change the speed and the rotation
            transform.SetParent(col.transform);
            //col.GetComponent<Circle>().speed *= -30;
            Score.PinCount++;
            isPinned = true;
        } else if (col.tag == "Pin")
        {
            //the end of the game is next
            FindObjectOfType<GameManager>().GameOver(); 
        }


    }
}
