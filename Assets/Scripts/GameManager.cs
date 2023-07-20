using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public string playerName;
    public TMP_InputField playerNameInput;
    private void Awake()
    {
        if(Instance != null)
        {
            Destroy(Instance);
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);

    }



    public void StartGame()
    {
        playerName = playerNameInput.text;
        SceneManager.LoadScene(1);
    }
 

}
