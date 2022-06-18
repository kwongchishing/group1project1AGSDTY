using UnityEngine;public class unlockplayer:MonoBehaviour{
    public goodbadcountgivepotion goodbadcountgivepotion;
    public GameObject player,finalbossfightbgm,finalbosssceneBGM,entertocontinue,exitcollider,finalbossHealthBar,finalbossforfight,finalbossfortalk,finaldragonfortalk,finaldragonforfight;
    void Update(){
        if(Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.E))
        {            
            player.GetComponent<Rigidbody>().constraints=RigidbodyConstraints.FreezeRotationX|RigidbodyConstraints.FreezeRotationY|RigidbodyConstraints.FreezeRotationZ;                    
            Destroy(finalbosssceneBGM);
            Destroy(entertocontinue);
            finalbossfightbgm.SetActive(true);
            exitcollider.SetActive(false);            
            finalbossfortalk.SetActive(false);
            finaldragonfortalk.SetActive(false);
            finalbossforfight.SetActive(true);
            finaldragonforfight.SetActive(true);
            finalbossHealthBar.SetActive(true);
            goodbadcountgivepotion.good++;
            player.GetComponent<Animator>().SetBool("stop",false);
            this.gameObject.SetActive(false);
        }
    }
}
