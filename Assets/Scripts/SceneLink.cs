using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneLink : MonoBehaviour
{
    public void GameToPerk()
    {
        SceneManager.LoadScene("Perks");
    }
    public void PerkToGame()
    {
        SceneManager.LoadScene("Game");
    }
    public void StartToGame() 
    {
        SceneManager.LoadScene("Game");
    }
}
