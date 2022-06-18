using UnityEngine;public class clickStartMaths:MonoBehaviour{
    public AudioSource startMathtestsound,test1Music;
    public GameObject cancelMathtestButton,BTN1,BTN2,BTN3,QuestionSet1,QuestionSet2,QuestionSet3;
    public correctCount cc;
    int randomQuestionSet;
    public void StartMathsTest(){
        startMathtestsound.Play();
        cancelMathtestButton.SetActive(false);
        randomQuestionSet=Random.Range(1,4);
        if(randomQuestionSet==1){
            QuestionSet1.SetActive(true);}
        if(randomQuestionSet==2){
            QuestionSet2.SetActive(true);
        }
        if(randomQuestionSet==3){
            QuestionSet3.SetActive(true);
        }
        cc.correctcount=0;
        test1Music.Play();
        this.gameObject.SetActive(false); 
    }
}