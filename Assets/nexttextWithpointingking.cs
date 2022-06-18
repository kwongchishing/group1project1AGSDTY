using UnityEngine;public class nexttextWithpointingking:MonoBehaviour{ 
    public GameObject nexttext,player,king; 
    void Update(){ 
        if(Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.E))
        { 
            nexttext.SetActive(true);player.GetComponent<Animator>().SetTrigger("pointing");
            player.transform.LookAt(new Vector3(king.transform.position.x,king.transform.position.y,king.transform.position.z));
            this.gameObject.SetActive(false);} } }