using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScores : MonoBehaviour
{
    public GameObject scorer;
    const string privateCode = "LV25cxIBiU23BkwrUrPEQgyEFpdqKJs0Ws9fvDAQfqgw";  //Key to Upload New Info
    const string hardPrivateCode = "bIXhwWycq0qyZvaCUux6uAoTCE5vC1qE-Le_QCNfwaww";
    const string publicCode = "637581a08f40bb1104442f0c";   //Key to download
    const string hardPublicCode = "637823cd8f40bb1104476fd9";
    const string webURL = "http://dreamlo.com/lb/"; //  Website the keys are for

    public PlayerScore[] scoreList;
    DisplayHighscores myDisplay;

    static HighScores instance; //Required for STATIC usability
    void Awake()
    {
        instance = this; //Sets Static Instance
        myDisplay = GetComponent<DisplayHighscores>();
    }
    
    public static void UploadScore(string username, int score)  //CALLED when Uploading new Score to WEBSITE
    {//STATIC to call from other scripts easily
        instance.StartCoroutine(instance.DatabaseUpload(username,score)); //Calls Instance
    }

    IEnumerator DatabaseUpload(string userame, int score) //Called when sending new score to Website
    {
        if (scorer.activeSelf) {
            WWW www = new WWW(webURL + privateCode + "/add/" + WWW.EscapeURL(userame) + "/" + score);
            yield return www;

            if (string.IsNullOrEmpty(www.error))
            {
                print("Upload Successful");
                DownloadScores();
            }
            else print("Error uploading" + www.error);
        }
        else
        {
            WWW www = new WWW(webURL + hardPrivateCode + "/add/" + WWW.EscapeURL(userame) + "/" + score);
            yield return www;

            if (string.IsNullOrEmpty(www.error))
            {
                print("Upload Successful");
                DownloadScores();
            }
            else print("Error uploading" + www.error);
        }
        
    }

    public void DownloadScores()
    {
        StartCoroutine("DatabaseDownload");
    }
    IEnumerator DatabaseDownload()
    {
        if (scorer.activeSelf)
        {
            //WWW www = new WWW(webURL + publicCode + "/pipe/"); //Gets the whole list
            WWW www = new WWW(webURL + publicCode + "/pipe/0/10"); //Gets top 10
            yield return www;

            if (string.IsNullOrEmpty(www.error))
            {
                OrganizeInfo(www.text);
                myDisplay.SetScoresToMenu(scoreList);
            }
            else print("Error uploading" + www.error);
        }
        else
        {
            //WWW www = new WWW(webURL + publicCode + "/pipe/"); //Gets the whole list
            WWW www = new WWW(webURL + hardPublicCode + "/pipe/0/10"); //Gets top 10
            yield return www;

            if (string.IsNullOrEmpty(www.error))
            {
                OrganizeInfo(www.text);
                myDisplay.SetScoresToMenu(scoreList);
            }
            else print("Error uploading" + www.error);
        }

    }

    void OrganizeInfo(string rawData) //Divides Scoreboard info by new lines
    {
        string[] entries = rawData.Split(new char[] {'\n'}, System.StringSplitOptions.RemoveEmptyEntries);
        scoreList = new PlayerScore[entries.Length];
        for (int i = 0; i < entries.Length; i ++) //For each entry in the string array
        {
            string[] entryInfo = entries[i].Split(new char[] {'|'});
            string username = entryInfo[0];
            int score = int.Parse(entryInfo[1]);
            scoreList[i] = new PlayerScore(username,score);
            print(scoreList[i].username + ": " + scoreList[i].score);
        }
    }
}

public struct PlayerScore //Creates place to store the variables for the name and score of each player
{
    public string username;
    public int score;

    public PlayerScore(string _username, int _score)
    {
        username = _username;
        score = _score;
    }
}