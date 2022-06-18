using System.Collections;using System.Collections.Generic;using UnityEngine;using UnityEngine.AI;public class afterAllthrow:MonoBehaviour{
    NavMeshAgent NM;
    float x,y,z;
    Vector3 pos;
    public AudioSource success,notsuccess,gethurt;
    public Save save;
    public GameObject NPC,player,finishandlessthan1Text,finishbutmorethan1Text,NPCcollider,rubbish1goUp,entertocontinue;
    Animator anim;
    public Animator rubbishanim;
    void Start(){
        x=Random.Range(338.9f,337.9f);
        y=Random.Range(50.4061f,50.406f);
        z=Random.Range(376.3f,359.7f);
        pos=new Vector3(x,y,z);
        NM=GetComponent<NavMeshAgent>();
        NM.SetDestination(pos);
        anim=NPC.GetComponent<Animator>();
        rubbishanim=rubbish1goUp.GetComponent<Animator>();
    }
    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag=="rubbishcollect"){
            this.gameObject.SetActive(false);            
            success.Play();
            transform.localPosition=new Vector3(-3.90000558f,0.999000251f,-2.18200088f);
            if(save.gethitbyRubbish<2){
                player.SetActive(false);
                player.SetActive(true);entertocontinue.SetActive(true);
                player.gameObject.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl>().enabled=false;
                player.transform.position=new Vector3(312.1635f,50.406f,365.0925f);
                player.transform.rotation=Quaternion.Euler(0f,-159.473f,0f);
                player.GetComponent<Rigidbody>().constraints=RigidbodyConstraints.FreezePositionX|RigidbodyConstraints.FreezePositionZ|RigidbodyConstraints.FreezeRotationX|RigidbodyConstraints.FreezeRotationY|RigidbodyConstraints.FreezeRotationZ;
                NPCcollider.SetActive(false);
                finishandlessthan1Text.SetActive(true);
                NPC.SetActive(false);
                NPC.SetActive(true);
                NPC.transform.localPosition=new Vector3(2.89999127f,0.133716747f,-2.10700417f);
                NPC.transform.rotation=Quaternion.Euler(358.230103f,275.54068f,5.33863229e-08f);
            }
            else{
                player.SetActive(false);
                player.SetActive(true);
                entertocontinue.SetActive(true);
                player.gameObject.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl>().enabled=false;
                player.transform.position=new Vector3(312.1635f,50.406f,365.0925f);
                player.transform.rotation=Quaternion.Euler(0f,-159.473f,0f);
                player.GetComponent<Rigidbody>().constraints=RigidbodyConstraints.FreezePositionX|RigidbodyConstraints.FreezePositionZ|RigidbodyConstraints.FreezeRotationX|RigidbodyConstraints.FreezeRotationY|RigidbodyConstraints.FreezeRotationZ;
                NPCcollider.SetActive(false);
                finishbutmorethan1Text.SetActive(true);
                NPC.SetActive(false);
                NPC.SetActive(true);
                NPC.transform.localPosition=new Vector3(2.89999127f,0.133716747f,-2.10700417f);
                NPC.transform.rotation=Quaternion.Euler(358.230103f,275.54068f,5.33863229e-08f);
            }
        }
        if(other.gameObject.tag=="Player"){
            this.gameObject.SetActive(false);
            notsuccess.Play();
            transform.localPosition=new Vector3(-3.90000558f,0.999000251f,-2.18200088f);
            gethurt.Play();
            save.gethitbyRubbish+=1;
            if(save.gethitbyRubbish<2){
                player.SetActive(false);
                player.SetActive(true); entertocontinue.SetActive(true);
                player.gameObject.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl>().enabled=false;
                player.transform.position=new Vector3(312.1635f,50.406f,365.0925f);
                player.transform.rotation=Quaternion.Euler(0f,-159.473f,0f);
                player.GetComponent<Rigidbody>().constraints=RigidbodyConstraints.FreezePositionX|RigidbodyConstraints.FreezePositionZ|RigidbodyConstraints.FreezeRotationX|RigidbodyConstraints.FreezeRotationY|RigidbodyConstraints.FreezeRotationZ;
                NPCcollider.SetActive(false);
                finishandlessthan1Text.SetActive(true);
                NPC.SetActive(false);
                NPC.SetActive(true);
                NPC.transform.localPosition=new Vector3(2.89999127f,0.133716747f,-2.10700417f);
                NPC.transform.rotation=Quaternion.Euler(358.230103f,275.54068f,5.33863229e-08f);
            }
            else{
                player.SetActive(false);
                player.SetActive(true); entertocontinue.SetActive(true);
                player.gameObject.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl>().enabled=false;
                player.transform.position=new Vector3(312.1635f,50.406f,365.0925f);
                player.transform.rotation=Quaternion.Euler(0f,-159.473f,0f);
                player.GetComponent<Rigidbody>().constraints=RigidbodyConstraints.FreezePositionX|RigidbodyConstraints.FreezePositionZ|RigidbodyConstraints.FreezeRotationX|RigidbodyConstraints.FreezeRotationY|RigidbodyConstraints.FreezeRotationZ;
                NPCcollider.SetActive(false);
                finishbutmorethan1Text.SetActive(true);
                NPC.SetActive(false);
                NPC.SetActive(true);
                NPC.transform.localPosition=new Vector3(2.89999127f,0.133716747f,-2.10700417f);
                NPC.transform.rotation=Quaternion.Euler(358.230103f,275.54068f,5.33863229e-08f);
            }
        }
    }
    void Update(){NM.SetDestination(pos);}
}