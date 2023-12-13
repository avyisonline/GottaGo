using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public Transform player;
    private float x = 0f;
    private float y = 1f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Death"))
        {
            player.transform.position = new Vector2 (x, y); 
        }
    }
}
