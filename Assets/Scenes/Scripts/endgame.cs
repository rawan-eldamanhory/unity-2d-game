using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endgame : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            EndGame();
        }
    }

    private void EndGame()
    {
        score.ResetScore();

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
