using System.Collections;using System.Collections.Generic;using UnityEngine;public class leavesportgame:MonoBehaviour{
    public GameObject player,sporthouse,minimap,mmpointer;
    public AudioSource backgroundmusic1,opendoorsound;
    void Update(){
        backgroundmusic1.Play();
        if(Input.GetKeyDown(KeyCode.Return)|| Input.GetKeyDown(KeyCode.E))
        {
            player.transform.position=new Vector3(323.9396f,30.57108f,294.0837f);
            player.transform.rotation=Quaternion.Euler(0f,103.718f,0f);
            opendoorsound.Play(); mmpointer.SetActive(true);
            sporthouse.SetActive(false);
            minimap.SetActive(true);
            this.gameObject.SetActive(false);}}}