using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif
using TMPro;

public class MenuUiHandler : MonoBehaviour
{
    public TMP_InputField inputField;
    // Start is called before the first frame update
    public void StartNew()
    {
        SceneManager.LoadScene(1);
        GetPlayerName();
        Debug.Log("Name is now: " + SaveManager.Instance.playerName);
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }

    private void GetPlayerName()
    {
        SaveManager.Instance.playerName = inputField.text;
    }


}
