using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class FallDeath : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Why did you do that?");
            QuitGame();
        }
    }

    public void QuitGame()
    {
#if UNITY_EDITOR

        EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
