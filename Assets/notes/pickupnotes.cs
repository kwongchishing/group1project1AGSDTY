using UnityEngine;using UnityEngine.UI;public class pickupnotes:MonoBehaviour{
    Animator anim;
    public GameObject pickuptext,document1;
    void Start(){anim=GetComponent<Animator>();}
    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag=="Player"){
            anim.SetTrigger("pickupnotes");
            pickuptext.SetActive(true);}}
    void OnTriggerExit(Collider other){
        if(other.gameObject.tag=="Player"){
            anim.Play("idle");
            pickuptext.SetActive(false);
            document1.SetActive(false);}}}