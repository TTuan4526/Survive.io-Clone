using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningController : MonoBehaviour
{
    public GameObject spawner;
    public UIManager uiManager;
    public GameManager gameManager;

    public GameObject spawnerLocalization;
    public GameObject monsterZone;
    internal bool checkWork = true;
    internal bool keepingGame = false;

    private void Update()
    {
        if (keepingGame)
        {
            //gameManager.ResumeBtn();
        }
        
    }
}
