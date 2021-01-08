using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update

    public static GameManager instance;
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }

    public void LoadLevel1()
    {
        SceneManager.LoadScene("Level1");
    }
    
    public void LoadLevel2()
    {
        SceneManager.LoadScene("Level2");
    }
    
    public void LoadLose()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
