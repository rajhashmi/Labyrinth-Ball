using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class GameplayController : MonoBehaviour{

    private Text countDownText;
    public int countDown = 100;

    void Awake(){
        countDownText = GameObject.Find("Countdown").GetComponent<Text>();
    }

    void Start()
    {
        StartCoroutine(StartCountDown());
        
    }

    // Update is called once per frame
    IEnumerator StartCountDown(){
        yield return new WaitForSeconds(1f);
        countDown--;
        if(countDown == 0){
            UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
        }
        countDownText.text = "Time Left: " + countDown;

        StartCoroutine(StartCountDown());


    }


   
}
