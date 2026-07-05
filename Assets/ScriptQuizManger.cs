using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptQuizManger : MonoBehaviour
{
    public List<QuestionsAndAnswers> QnA;
    public GameObject[] options;
    public int currentQuestion;

    public Text QuestionText;

    private void Start()
    {
        generateQuestion();
    }

    void SetAnswers()
    {
        if (!HasValidCurrentQuestion() || options == null)
        {
            return;
        }

        string[] answers = QnA[currentQuestion].Answers;
        for (int i = 0; i < options.Length; i++)
        {
            if (options[i] == null)
            {
                continue;
            }

            Text answerText = options[i].GetComponentInChildren<Text>();
            if (answerText == null)
            {
                continue;
            }

            answerText.text = answers != null && i < answers.Length ? answers[i] : string.Empty;
        }
    }

    void generateQuestion()
    {
        if (QnA == null || QnA.Count == 0)
        {
            currentQuestion = -1;
            if (QuestionText != null)
            {
                QuestionText.text = string.Empty;
            }
            return;
        }

        currentQuestion = Random.Range(0, QnA.Count);
        QuestionsAndAnswers question = QnA[currentQuestion];

        if (QuestionText != null)
        {
            QuestionText.text = question != null ? question.Question : string.Empty;
        }

        if (question == null)
        {
            return;
        }

        int answerCount = question.Answers != null ? question.Answers.Length : 0;
        bool hasValidCorrectAnswer = question.correctAnswer >= 0 && question.correctAnswer < answerCount;
        if (!hasValidCorrectAnswer)
        {
            // The current static quiz panels do not use correctAnswer yet; keep the manager optional.
        }

        SetAnswers();
    }

    bool HasValidCurrentQuestion()
    {
        return QnA != null && currentQuestion >= 0 && currentQuestion < QnA.Count && QnA[currentQuestion] != null;
    }
}
