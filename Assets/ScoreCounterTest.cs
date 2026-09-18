using UnityEngine;
using UnityEngine.UI;
public class ScoreCounterTest : MonoBehaviour
{
    Text scoreCounterTextObject;
    int score=0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreCounterTextObject = GetComponent<Text>();
        scoreCounterTextObject.text= "Starting Up";
    }

    // Update is called once per frame
    void Update()
    {
     if(Input.GetMouseButtonDown(0)){
        score+=100;
        scoreCounterTextObject.text=score.ToString();
     }   
    }
}
