using UnityEngine;using UnityEngine.UI;public class inputwords5tospace:MonoBehaviour{
    public GameObject Player;
    public sentenceFunction sentenceFunction;
    public Text words5,words1space,words2space,words3space,words4space,words5space;
    void Update(){
        if(Input.GetKeyDown(KeyCode.Return)&&Player.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Grounded")|| Input.GetKeyDown(KeyCode.E) && Player.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Grounded"))
        {
            if(sentenceFunction.word1full==0){
                words1space.text=words5.text;
                sentenceFunction.word1full=1;
            }
            else if(sentenceFunction.word2full==0){
                words2space.text=words5.text;
                sentenceFunction.word2full=1;
            }
            else if(sentenceFunction.word3full==0){
                words3space.text=words5.text;
                sentenceFunction.word3full=1;
            }
            else if(sentenceFunction.word4full==0){
                words4space.text=words5.text;
                sentenceFunction.word4full=1;
            }
            else if(sentenceFunction.word5full==0){
                words5space.text=words5.text; sentenceFunction.correctcount++;
                sentenceFunction.word5full=1;
            }
            this.gameObject.SetActive(false);
        }
    }
}