using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int playerRank;
    public bool playerCrownActivity;
    public List<Transform> playerPositions;


    [Header("Panels")]
    public GameObject generalGroup;
    public GameObject LevelComplete;
    public GameObject LevelFail;


   
    private void Awake()
    {
        instance = this;
    }

    //public void GeneralPanelOff()
    //{
    //    generalGroup.SetActive(false);
    //}

    public void LevelCompletePanelOn()
    {
        StartCoroutine(LevelCompleteDelay());
    }

    public void LevelFailPanelOn()
    {
        StartCoroutine(LevelFailDelay());
    }

    public void PlayerRankIncrement()
    {
        playerRank++;
    }

    public void PlayerCrownActive()
    {
        playerCrownActivity = true;
    }

    public void PlayerCrownNotActive()
    {
        playerCrownActivity = false;
    }

    IEnumerator LevelCompleteDelay()
    {
        yield return new WaitForSeconds(2); 
        generalGroup.SetActive(false);
        LevelComplete.SetActive(true);
    }

    IEnumerator LevelFailDelay()
    {
        yield return new WaitForSeconds(2);
        generalGroup.SetActive(false);
        LevelFail.SetActive(true);
    }
}
