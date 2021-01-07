using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestScript : MonoBehaviour
{
    public Text myText; 

    // Start is called before the first frame update
    void Start()
    {
        Quiz myQuiz = Model.getInstance();
        myText.text = myQuiz.readQuestions();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
