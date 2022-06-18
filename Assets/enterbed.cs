using UnityEngine;public class enterbed:MonoBehaviour{
    public GameObject saved,enterpotionshoptext;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player"| other.gameObject.tag == "Player2") { enterpotionshoptext.SetActive(true); }
    }
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" | other.gameObject.tag == "Player2") { enterpotionshoptext.SetActive(true); }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player" | other.gameObject.tag == "Player2") { enterpotionshoptext.SetActive(false);saved.SetActive(false);}
    }
}