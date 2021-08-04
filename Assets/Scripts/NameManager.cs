using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameManager : MonoBehaviour
{

    public static NameManager Instance;
    public string username;
    public int bestScore;
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
