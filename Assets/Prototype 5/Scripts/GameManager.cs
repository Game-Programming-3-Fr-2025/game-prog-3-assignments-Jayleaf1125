using System;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    float timer = 0;    
    [SerializeField] TMP_Text timerText;
    [SerializeField] PlayerTimeLoop timeLoop;
    bool _isPosLoading = false;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {     
        timerText.text = $"0:00";
        //timeLoop = GameObject.Find("Player").GetComponent<PlayerTimeLoop>();
    }

    // Update is called once per frame
    void Update()
    {
        Timer();
    }

    //void ReloadCurrentScene() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    void Timer()
    {
        timer += Time.fixedDeltaTime;
        int seconds = Mathf.FloorToInt(timer % 60);
        //float newTime = Mathf.Floor(timer + Time.fixedDeltaTime);
        //timer = (newTime != timer) ? newTime : timer;
        Debug.Log(seconds);

        //if (timer % 2 == 0)
        //{
        //    timeLoop.SavePositions();
        //}

        //if (timer > 10f)
        //{
        //    //_isPosLoading = true;
        //    timeLoop.LoadPositions();
        //    timer = 0f;
        //}

        //timerText.text = Convert.ToString(timer);

        //if (timer >= 600)
        //{
        //    timerText.text = "Time - 0:00";
        //    return;
        //}

        //ConvertToTimeText(timer);
    }

    void ConvertToTimeText(float timer)
    {
        int minutes = Mathf.FloorToInt(timer / 60);
        int seconds = Mathf.FloorToInt(timer % 60);
        timerText.text = string.Format("Time - {0:00}: {1:00}", minutes, seconds);
    }
}
