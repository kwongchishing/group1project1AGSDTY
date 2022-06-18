using UnityEngine;public class AnswerScript:MonoBehaviour{
    public AudioSource getitemSound,errorSound;
    public correctCount correctCount;
    public bool isCorrect=false;
    public QuizManager quizManager;
   public void Answer(){
        if(isCorrect){
            correctCount.correctcount++;
            quizManager.correct();
            getitemSound.Play();
        }
        else{
            quizManager.correct();
            errorSound.Play();
        }
    }
}