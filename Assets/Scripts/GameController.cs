using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour

{
    public bool isEndGame = false;
    bool isStartFirstTime = true;
    int gamePoint = 0;
    public Text txtPoint;
    public GameObject panelEndgame;
    public Text txtEndPoint;
    public Button btRestart;
    public Sprite btnIdle;
    public Sprite btnHover;
    public Sprite btnClick;
    // Start is called before the first frame update
    void Start()
    {
        panelEndgame.SetActive(false);
        Time.timeScale = 0;
        isStartFirstTime = true;
        isEndGame = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isEndGame)
        {
            if (Input.GetMouseButtonDown(0) && isStartFirstTime)
            {
                //load man choi
                StartGame();
            }
        }
        else
        {
            if (Input.GetMouseButtonDown(0))
            {
                Time.timeScale = 1;

            }
        }
        
        
    }
    public void RestartBtnClick()
    {
        btRestart.GetComponent<Image>().sprite = btnClick;
    }
    public void RestartBtnHover()
    {
        btRestart.GetComponent<Image>().sprite = btnHover;
    }
    public void RestartButtonIdle()
    {
        btRestart.GetComponent<Image>().sprite = btnIdle;
    }
    void StartGame()
    {
        SceneManager.LoadScene(0);
    }
    public void GetPoint()
    {
        gamePoint++;
        txtPoint.text = "Point: " + gamePoint.ToString();
    }
    public void EndGame()
    {
       // Debug.Log("End game");
        Time.timeScale = 0;
        isEndGame = true;
        isStartFirstTime = false;
        panelEndgame.SetActive(true);
        txtEndPoint.text = "Your point\n" + gamePoint.ToString();
    }
    public void Restart()
    {
        StartGame();
    }
   
}
