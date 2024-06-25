using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public Camera mainCamera;
    public Camera menuCamera;
    public Image startButton;
    public Image quitButton;
    public Sprite startSelectedSprite;
    public Sprite startUnselectedSprite;
    public Sprite quitSelectedSprite;
    public Sprite quitUnselectedSprite;

    private int selectedIndex = 0; // 0: Start, 1: Quit

    // Start is called before the first frame update
    void Start()
    {
        UpdateButtonImages();
    }

    // Update is called once per frame
    void Update()
    {
        HandleInput();
        UpdateButtonImages();
    }

    void HandleInput()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            selectedIndex = (selectedIndex == 0) ? 1 : 0;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            selectedIndex = (selectedIndex == 1) ? 0 : 1;
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            ExecuteSelectedButton();
        }
    }

    void UpdateButtonImages()
    {
        if (selectedIndex == 0)
        {
            startButton.sprite = startSelectedSprite;
            quitButton.sprite = quitUnselectedSprite;
        }
        else
        {
            startButton.sprite = startUnselectedSprite;
            quitButton.sprite = quitSelectedSprite;
        }
    }

    void ExecuteSelectedButton()
    {
        if (selectedIndex == 0)
        {
            StartGame();
        }
        else if (selectedIndex == 1)
        {
            QuitGame();
        }
    }

    void StartGame()
    {
        // 게임 시작 로직
        Debug.Log("Start Game");
        mainCamera.gameObject.SetActive(true);
        menuCamera.gameObject.SetActive(false);
        this.gameObject.SetActive(false);
    }

    void QuitGame()
    {
        // 게임 종료 로직
        Debug.Log("Quit Game");
        Application.Quit();
    }
}
