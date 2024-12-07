using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUIHandler : MonoBehaviour
{
    public TextMeshProUGUI bestScoreText;
    public TMP_InputField playerNameField;
    public void StartGame()
    {
        GameManager.Instance.tmp_playerName = playerNameField.text;
        SceneManager.LoadScene(1);
    }
    public void QuitGame()
    {
        GameManager.Instance.SavePlayerData();
        #if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
        #else   
            Application.Quit();
        #endif
    }
    void Start()
    {
        GameManager.Instance.LoadPlayerData();
        bestScoreText.text = "Best score : " + GameManager.Instance.playerName + " : " + GameManager.Instance.playerScore;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
