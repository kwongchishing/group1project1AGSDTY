using UnityEngine;public class equipAXE:MonoBehaviour{
    public GameObject getAXEIMG,equipAXEText,AXE,w_AXEplayer,player;
    public AudioSource getitemsound;
    public Save save;
    void Update(){Destroy(AXE);
        if(Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.E))
        {
            save.w_AXE+=1;
            equipAXEText.SetActive(true);
            getitemsound.Play();
            Destroy(getAXEIMG);
            w_AXEplayer.SetActive(true);
            w_AXEplayer.gameObject.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl>().enabled=false;
            Destroy(this.gameObject);
            Destroy(player);}}}