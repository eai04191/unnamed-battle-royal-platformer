using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    private bool firstPush = false;
    public void PressStart()
    {
        Debug.Log("Press Start!");
        if (!firstPush) {
            Debug.Log("gameシーンへ遷移");
            SceneManager.LoadScene("game");
            firstPush = true;
        }
    }
}
