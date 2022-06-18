using UnityEngine;public class transferToOldUG:MonoBehaviour{
    public GameObject tunnelpointer,player,tunnel,backgroundmusic5,bg1,All_Bullenemy,underGroundscene,exitunderground;
    public AudioSource backgroundmusicUG,backgroundmusic1;
        void OnTriggerEnter(Collider other){
            if(other.gameObject.tag=="Player"){
            underGroundscene.SetActive(true);
            exitunderground.SetActive(false);
                player.transform.position=new Vector3(-9.476361f,16.770000457763672f,-306.8816f);
                player.transform.rotation=Quaternion.Euler(0,97.809f,0);tunnel.SetActive(false);
            bg1.SetActive(true);
            backgroundmusic1.Stop();
                backgroundmusicUG.Play();
                backgroundmusic5.SetActive(false);All_Bullenemy.SetActive(true);
            tunnelpointer.SetActive(false);
        }
        }
        void OnTriggerStay(Collider other){
            if(other.gameObject.tag=="Player"){
            underGroundscene.SetActive(true);
            exitunderground.SetActive(false);
            player.transform.position=new Vector3(-9.476361f,16.770000457763672f,-306.8816f);
            player.transform.rotation=Quaternion.Euler(0,97.809f,0);tunnel.SetActive(false);
            bg1.SetActive(true);
            backgroundmusic1.Stop();
            backgroundmusicUG.Play();
            backgroundmusic5.SetActive(false);All_Bullenemy.SetActive(true);
            tunnelpointer.SetActive(false);
        }
        }    }