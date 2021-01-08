using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    // Start is called before the first frame update
    private int score;
    [SerializeField] private Text text;
    [SerializeField] private float levelLength;
    [SerializeField] private float levelTimer;
    [SerializeField] private string nextLevel;
    void Start()
    {
        SetText();
        levelTimer = levelLength;
    }

    void Update()
    {
        levelTimer -= Time.deltaTime;
        if (levelTimer <= 0)
        {
            GameManager.instance.score += score;
            SceneManager.LoadScene(nextLevel);
        }
    }

    void SetText()
    {
        text.text = "Score: " + score;
    }
    
    // Update is called once per frame
    public void IncreaseScore(int amount)
    {
        score += amount;
        SetText();
    }
}
