using UnityEngine;public class killNPCanimation:MonoBehaviour{
    public GameObject unrealboss,afterLosetalk;
    Animator anim;
    void Start(){
        anim=unrealboss.GetComponent<Animator>();}
    void Update(){
        if(Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.E))
        {
            anim.SetBool("killplayer",true);
            Destroy(this.gameObject);
            Destroy(afterLosetalk);}}}