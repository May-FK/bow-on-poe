using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine.UI;
using UnityEngine;
using System.Linq;


public class GameManager : MonoBehaviour
{
    /*public Questions[] questions;
    private static List<Question> unansweredQuestions;
    private Question currentQuestion;

    void Start()
    {
        if (unansweredQuestions == null || unansweredQuestions.Count == 0)
        {
            unansweredQuestions = questions.ToList<questions>();

            GetRandomQuestion();
            Debug.Log(currentQuestion.correct + "is" + currentQuestion.isRight);
        }

        void GetRandomQuestion()
        {
            int randomQuestionIndex = randomQuestionIndex.Range(0, unansweredQuestions.Count);
            currentQuestion = unansweredQuestions[randomQuestionIndex];

            unansweredQuestions.RemoveAt(randomQuestionIndex);
        }
    }*/

    public void UserSelectTrue()
    {

    }
}
