using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour

{
    public GameObject gameModeSelectionScreen;
    void Start()
    {
        gameModeSelectionScreen.gameObject.SetActive(false);
    }

    void Update()
    {
        
    }

    public void openScreen (GameObject screen)
    {
        screen.SetActive(true);
    }

    public void closeScreen(GameObject screen)
    {
        screen.SetActive(false);
    }

}
