using UnityEngine;using UnityEngine.UI;public class pickupnotes2:MonoBehaviour{
    Animator anim;
    public GameObject pickuptextpink,pickuptext, document1;
    void Start() { anim=GetComponent<Animator>(); }
    void OnTriggerEnter(Collider other){
        if (other.gameObject.tag == "Player")
        {
            anim.SetTrigger("pickupnotes");
            pickuptext.SetActive(true);
        }
        if (other.gameObject.tag == "Player2")
        {
            anim.SetTrigger("pickupnotes");
            pickuptextpink.SetActive(true);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            anim.Play("idle");
            pickuptext.SetActive(false);
            document1.SetActive(false);
        }
        if (other.gameObject.tag == "Player2")
        {
            anim.Play("idle");
            pickuptextpink.SetActive(false);
            document1.SetActive(false);
        }
    }
}