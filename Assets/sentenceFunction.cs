using UnityEngine;using UnityEngine.UI;public class sentenceFunction:MonoBehaviour{
    public float word1full,word2full,word3full,word4full,word5full,correctcount;
    public GameObject NotAllCorrectTxt,buttoncollider,Player,correctcollider,AllwordsSpace;
    public AudioSource errorSound;
    public Text words1space,words2space,words3space,words4space,words5space,NotallCorrectTxt;
    void Update(){
        if(word5full>=1&&correctcount<5){
            errorSound.Play();
           word1full=0;
            word2full=0;
           word3full=0;
        word4full=0;
           word5full=0;
            correctcount=0;
            NotAllCorrectTxt.SetActive(true);
            NotallCorrectTxt.text="我： "+words1space.text+words2space.text+words3space.text+words4space.text+words5space.text+" 不對......文件到底想說什麼？！";
            words1space.text="";
           words2space.text="";
           words3space.text="";
          words4space.text="";
           words5space.text="";
        }
        else if(word5full>=1&&correctcount==5){
            Destroy(buttoncollider);
            correctcollider.SetActive(true);
            Player.gameObject.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl>().enabled=false;
            Player.GetComponent<Animator>().SetBool("stop",true);
            Player.GetComponent<Rigidbody>().constraints=RigidbodyConstraints.FreezePositionX|RigidbodyConstraints.FreezePositionZ|RigidbodyConstraints.FreezeRotationX|RigidbodyConstraints.FreezeRotationY|RigidbodyConstraints.FreezeRotationZ;
            Player.transform.position=new Vector3(-519.671265f,372.032501f,-1614.8999f);
            Player.transform.rotation=Quaternion.Euler(0,271.831f,0);
            AllwordsSpace.SetActive(false);
        }
    }
}