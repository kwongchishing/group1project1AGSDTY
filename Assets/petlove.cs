using UnityEngine;public class petlove:MonoBehaviour{
    public float timecount;
    public bool isshit;
    public GameObject shit;
    void Start(){
        isshit=false;
        timecount=0;
    }        
    void Update(){
        if(isshit==false){timecount+=1*Time.deltaTime;}
        if(timecount>=100){
            isshit=true;
            shit.SetActive(true);
            timecount=0;
        }
    }
}