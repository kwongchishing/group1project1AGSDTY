using UnityEngine;public class sisterTopotionshop:MonoBehaviour{
    public GameObject Player2;
    public float distance;
    public Transform p1,p2;
    public save2 save2;
    public AudioSource potionShopSong,opendoorsound;
    public GameObject Player1,newbgm1,realPotionHouse;
    void Update(){
        distance=Vector3.Distance(p1.transform.position,p2.transform.position);
        if(Input.GetKeyDown(KeyCode.KeypadEnter)){
            if (save2.finishgame < 1) realPotionHouse.SetActive(true);
            opendoorsound.Play();
            Player2.transform.position=new Vector3(979.0994873046875f, -130.95004272460938f, 124.46919250488281f);
            Player2.transform.rotation=Quaternion.Euler(0,261.958008f,0);
            Player2.GetComponent<Animator>().SetBool("nojump",true);
            save2.isinshop=true;
            if(distance<=8f){
                Player1.transform.position=new Vector3(979.0994873046875f, -130.95004272460938f, 124.46919250488281f);
                Player1.transform.rotation=Quaternion.Euler(0,261.958008f,0);
                potionShopSong.Play();
                newbgm1.SetActive(false);Player1.GetComponent<Animator>().SetBool("nojump",true);
                save2.isinshop=true;
            }
        }
    }
}