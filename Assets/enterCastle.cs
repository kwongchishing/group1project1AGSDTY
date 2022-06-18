using UnityEngine;public class enterCastle:MonoBehaviour{
    public GameObject tunnelpointer,player,backgroundmusic5,tunnel,prison,prisonbgm;
    public AudioSource opencastledoorSound;
    void Update(){
        if(Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.E))
        {
            prison.SetActive(true);
            player.transform.position=new Vector3(-529.033569f,372.032501f,-1596.8512f);
            player.transform.rotation=Quaternion.Euler(0,92.668f,0);
            opencastledoorSound.Play();
            tunnelpointer.SetActive(false);
            backgroundmusic5.SetActive(false);prisonbgm.SetActive(true);tunnel.SetActive(false);
        }
    }
}