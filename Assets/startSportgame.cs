using UnityEngine;public class startSportgame:MonoBehaviour{
    public GameObject entertocontinue,player,npc,sportrule,cancelPlay,blockexit,windblock;
    public AudioSource getitemSound,test2music;
    public void startsportgame(){
        player.transform.position=new Vector3(340.982269f,50.4061f,372.845245f);
        player.transform.rotation=Quaternion.Euler(0,-92.276f,0);        
        npc.transform.position=new Vector3(310.406494f,50.4060f,373.452189f);
        entertocontinue.SetActive(true);
        sportrule.SetActive(true);
        test2music.Play();
        blockexit.SetActive(true);
        cancelPlay.SetActive(false);
        windblock.SetActive(false);
        getitemSound.Play();
        this.gameObject.SetActive(false);
    }
}