using UnityEngine;public class rubbishgoup:MonoBehaviour{
    Animator anim;
    Animator animNPC;
    public GameObject NPC;
    void Start(){
        anim=GetComponent<Animator>();
        animNPC=NPC.GetComponent<Animator>();
        animNPC.SetTrigger("Idlegirl");
        animNPC.SetTrigger("throw");
      anim.SetTrigger("fly");
    }
    void Update(){
        NPC.transform.position=new Vector3(310.406494f,50.4060f,373.452189f);
        animNPC.SetTrigger("Idlegirl");
        animNPC.SetTrigger("throw");
        anim.SetTrigger("fly");
    }
}