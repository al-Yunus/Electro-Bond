using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject pauseUI;
    public GameObject movesetUI;
    public GameObject gameUI;
    public GameObject startroundUI;

    public void OnAttackPress(){
        startroundUI.SetActive(false);
        movesetUI.SetActive(true);
    }

    public void OnEndTurnPress(){
        gameUI.SetActive(false);
    }
    public void OnInsightPress(){
        pauseUI.SetActive(true);
    }
    public void OnEnterBackPress() {
        pauseUI.SetActive(false);
        movesetUI.SetActive(false);
        startroundUI.SetActive(true);
    }
}
