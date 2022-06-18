using System.Collections;using System.Collections.Generic;using UnityEngine;using UnityEngine.UI;public class QuizManager:MonoBehaviour{
    public List<QuestionAndAnswers> QnA;
    public GameObject[] options;
    public int currentQuestion;
    public correctCount correctCount;
    public Text QuestionTxt;
    public Save save;   
    public GameObject finishbutnotAllcorrect,Panel,finishallCorrect,QuestionText,BTN1,BTN2,BTN3,entertocontinue;
    void Start(){
        generateQuestion();
    }
    public void correct() //answered
    {        
            QnA.RemoveAt(currentQuestion);
            generateQuestion();
    }
    void SetAnswers(){
        for(int i=0;i<options.Length;i++){
            options[i].GetComponent<AnswerScript>().isCorrect=false;
            options[i].transform.GetChild(0).GetComponent<Text>().text=QnA[currentQuestion].Answers[i];
            if(QnA[currentQuestion].CorrectAnswer==i+1){
                options[i].GetComponent<AnswerScript>().isCorrect=true;
            }
        }
    }
    void generateQuestion(){
        if(QnA.Count>0){
currentQuestion=Random.Range(0,QnA.Count);
        QuestionTxt.text=QnA[currentQuestion].Question;
        SetAnswers();  
        }
        else{
            if(correctCount.correctcount<=4){
                finishbutnotAllcorrect.SetActive(true);
                correctCount.retryOrnot++;
                QuestionText.SetActive(false);
                BTN1.SetActive(false);
                BTN2.SetActive(false);
                BTN3.SetActive(false);
                entertocontinue.SetActive(true);
            }
            else{
                finishallCorrect.SetActive(true);
                save.finishMaths++;
                QuestionText.SetActive(false);
                BTN1.SetActive(false);
                BTN2.SetActive(false);
                BTN3.SetActive(false);
                entertocontinue.SetActive(true);
            }
        }
    }
}