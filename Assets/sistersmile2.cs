using UnityEngine;public class sistersmile2:MonoBehaviour{
    public AudioSource sistersmile;
    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag=="Player"){
            sistersmile.Play();
        }
    }
}