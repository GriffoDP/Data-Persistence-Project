using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class UIMenuScene : MonoBehaviour
{
    public TMP_InputField usernameText;
    public TextMeshProUGUI bestScoreText;

    // Start is called before the first frame update
    void Start()
    {
        bestScoreText.text = $"Best Score: {NameManager.Instance.bestUsername}: " + NameManager.Instance.bestScore;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateUsername()
    {
        NameManager.Instance.currentUsername = usernameText.text;
    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
    Application.Quit();
#endif
    }
}
