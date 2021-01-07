using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    // Start is called before the first frame update
    private int score;
    [SerializeField] private Text text;
    void Start()
    {
        SetText();
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
