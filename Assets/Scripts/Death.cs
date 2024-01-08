using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    public Transform player;
    private float x = 0f;
    private float y = 1f;

    float lives = 3f;

    private void Update()
    {
        if (lives < 0f)
        {
            SceneManager.LoadScene("Death");
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            player.transform.position = new Vector2 (x, y);
            --lives;
        }
    }
}
