using UnityEngine;public class exitcastle:MonoBehaviour{
    public GameObject player, finalbossscene, prison, prisonbgm,finalbossscenebgm;
    public AudioSource opencastledoorSound;
    void Update(){
        if (Input.GetKeyDown(KeyCode.Return)){
            prison.SetActive(true);
            player.transform.position=new Vector3(-514.748962f,372.032501f,-1614.401f);
            player.transform.rotation=Quaternion.Euler(0,2.722f,0);
            opencastledoorSound.Play(); prisonbgm.SetActive(true);
            finalbossscene.SetActive(false); finalbossscenebgm.SetActive(false);
        }
    }
}