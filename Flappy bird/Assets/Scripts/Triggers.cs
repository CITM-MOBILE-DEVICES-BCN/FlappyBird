using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggers : MonoBehaviour
{

    public AudioClip scoreSound;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.instance.GameOver();

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Score.instance.UpdateScore();
            SoundManager.instance.PlaySound(scoreSound);

        }
    }
}
