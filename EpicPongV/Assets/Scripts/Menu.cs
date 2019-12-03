using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene("Level01");
    }
    public void Multiplayer()
    {
        SceneManager.LoadScene("Multiplayer");
    }
}
