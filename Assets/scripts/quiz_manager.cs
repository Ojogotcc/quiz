using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class quiz_manager : MonoBehaviour
{
    [Header("Variaveis de Painel")]
    public GameObject startPanel;
    public GameObject gamePanel;

    [Header("Objetos do jogo")]
    public TMP_Text textTitle;
    public TMP_Text textQuestion;
    public Image imageQuiz;
    public TMP_Text[] textAnswer;

    [Header("Conteudo das perguntas")]
    public string[] titles;
    public Sprite[] images;
    public string[] questions;
    public string[] alternative1;
    public string[] alternative2;
    public string[] alternative3;
    public string[] alternative4;
    public int[] correctAnswer;
    public int nowQuestion;


    // Start is called before the first frame update
    void Start()
    {
        startPanel.SetActive(true);
        gamePanel.SetActive(false);
    }

    // metod to start game
    public void GameStart()
    {
        startPanel.SetActive(false);
        gamePanel.SetActive(true);
        NextQuestion(nowQuestion);
    }

    // metod to make questions
    public void NextQuestion(int number)
    {
        textTitle.text = titles[number];
        imageQuiz.sprite = images[number];
        textQuestion.text = questions[number];
        textAnswer[0].text = alternative1[number];
        textAnswer[1].text = alternative2[number];
        textAnswer[2].text = alternative3[number];
        textAnswer[3].text = alternative4[number];
    }

    public void CheckResponse(int number)
    {
        if (number == correctAnswer[nowQuestion])
        {
            Debug.Log("Acertou a pergunta" + nowQuestion + 1);
        }
        else
        {
            Debug.Log("Errou a pergunta" + nowQuestion + 1);
        }
        nowQuestion++;
        if (nowQuestion >= titles.Length)
        {
            startPanel.SetActive(true);
            gamePanel.SetActive(false);
            nowQuestion = 0;
        }
        else
        {
            NextQuestion(nowQuestion);
        }
    }
}