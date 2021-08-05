using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class NameManager : MonoBehaviour
{

    public static NameManager Instance;
    public string bestUsername;
    public int bestScore;
    public string currentUsername;
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

        LoadScore();
    }

    [System.Serializable]
    class SaveData
    {
        public string bestUsername;
        public int bestScore;
    }

    public void SaveScore()
    {
        SaveData data = new SaveData();
        data.bestUsername = bestUsername;
        data.bestScore = bestScore;

        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            bestUsername = data.bestUsername;
            bestScore = data.bestScore;
        }
    }

    private void OnDestroy()
    {
        SaveScore();
    }

}
