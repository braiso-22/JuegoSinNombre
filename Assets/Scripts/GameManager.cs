using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;



public class GameManager : MonoBehaviour
{

    private static GameManager instance;
    [Header("Items")]
    public int itemsToCollect;
    [SerializeField] public int itemsCollected;
    public bool hasItem;
    public string lastItemName = "";
    [Header("PowerUps")]
    public bool hasPowerUp;

    [Header("game")]
    public bool hasWon;
    public bool gameOver;

    [Header("UI")]
    public GameObject menu;
    public GameObject winMenu;
    public TextMeshProUGUI winTimer;
    public bool menuActive = false;
    public bool menuBlocked = false;
    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = GameObject.FindObjectOfType<GameManager>();
            }
            return instance;
        }
    }
    void onAwake()
    {
        instance = this;
        DontDestroyOnLoad(this);
    }
    public void activarMenu()
    {
        if (!menuBlocked)
        {
            if (menuActive)
            {
                Time.timeScale = 1;

                menu.SetActive(false);
                menuActive = false;
                AudioManager.Instance.Play("boton2");
            }
            else
            {
                AudioManager.Instance.Play("boton1");
                Time.timeScale = 0;
                menu.SetActive(true);
                menuActive = true;
            }
        }
    }
    public void Win()
    {
        blockMenu();
        hasWon = true;
        AudioManager.Instance.Stop("InGame");
        AudioManager.Instance.Play("Win");
        Time.timeScale = 0;
        winMenu.SetActive(true);
        winTimer.text = "Tiempo: " + Timer.Instance.ToMinutes();
;
        menu.SetActive(false);
        menuActive = false;

    }
    public void blockMenu()
    {
        menuBlocked = !menuBlocked;
    }

    public void changeToScene(int num)
    {
        hasWon = false;
        gameOver = false;
        hasPowerUp = false;
        StartCoroutine(changeRoutine(num));
        Time.timeScale = 1;
        if (num != 0)
        {
            Timer.Instance.ResetTimer();
        }  
    }
    IEnumerator changeRoutine(int num)
    {
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene(num);
    }
    IEnumerator restartRoutine()
    {
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
    }
    public void exitGame()
    {
        Debug.Log("salir");
        Application.Quit();
    }

    public void restartGame()
    {
        Debug.Log("reiniciar");
        StartCoroutine(restartRoutine());
        Time.timeScale = 1;
       Timer.Instance.ResetTimer();
    }
    public Timer getTimer()
    {
        return Timer.Instance;
    }

}