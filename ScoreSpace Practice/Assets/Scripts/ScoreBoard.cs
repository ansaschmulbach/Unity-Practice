using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBoard : MonoBehaviour
{
    const string privateCode = "NOT THIS TIME BITCOIN HACKERS!";
    const string publicCode = "5ff7d3190af26924d02fc9c6";
    const string webURL = "http://dreamlo.com/lb/";
    void Awake() {
        print("HELLO?????");
        AddNewHighscore("oliver", 200);
        AddNewHighscore("ansa", 500);
    }
    public void AddNewHighscore(string username, int score) {
        StartCoroutine(UploadNewHighscore(username, score));
    }
    IEnumerator UploadNewHighscore(string username, int score) {
        WWW www = new WWW(webURL + privateCode + "/add/" + WWW.EscapeURL(username) + "/" + score);
        yield return www;
        if (string.IsNullOrEmpty(www.error)) {
            print("Upload Successful!");
        } else {
            print("Upload Failed: " + www.error);
        }
    }
    public void DownloadHighscores() {
        StartCoroutine("DownloadHighscoresFromDatabase");
    }
    IEnumerator DownloadHighscoresFromDatabase()
    {
        WWW www = new WWW(webURL + publicCode + "/pipe/");
        yield return www;
        if (string.IsNullOrEmpty(www.error)) {
            print(www.text);
        }
        else {
            print("Upload Failed: " + www.error);
        }
    }
}
