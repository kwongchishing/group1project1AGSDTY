using UnityEngine;public class goodbadcountgivepotion:MonoBehaviour{
    public int good;
    public float count;
    public GameObject kinggivepotion,kingpotion01;
    public save2 save2;
    void Update(){
        if(good==1&&save2.goodbadcount<=50) count+=1f*Time.deltaTime;
        if(count>=10.0f&&count<11f){
            kinggivepotion.SetActive(true);
                kingpotion01.SetActive(true);
            good=0;}
    }
}