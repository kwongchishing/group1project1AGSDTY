using UnityEngine;public class boss1bipLookatPlayer:MonoBehaviour{
    Animator anim;
    public Transform Player;
    public float pushcount;
    public GameObject pushSoundObject,boss1rotatebody,boss1rotateSound;
    void Start(){anim=GetComponent<Animator>();}
    void Update(){transform.LookAt(new Vector3(Player.transform.position.x, transform.position.y, Player.transform.position.z));}
    private void OnTriggerEnter(Collider other){
        if(other.gameObject.tag=="Player"&&!anim.GetCurrentAnimatorStateInfo(0).IsName("boss1rotateattack"))
        {
            pushSoundObject.SetActive(true);
            anim.SetBool("push",true);
            pushcount+=1;}}
    private void OnTriggerStay(Collider other){
        if(other.gameObject.tag=="Player"){
            pushSoundObject.SetActive(true);
            anim.SetBool("push",true);
            pushcount+=1*Time.deltaTime;}}
    private void OnTriggerExit(Collider other){
        if(other.gameObject.tag=="Player"){
            pushSoundObject.SetActive(false);
            anim.SetBool("push",false);}}}