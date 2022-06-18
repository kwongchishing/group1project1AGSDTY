using UnityEngine;public class AXEplayerLeaveMathhouse:MonoBehaviour{
    public AudioSource opendoorsound;
    public GameObject mmpointer,Mathselearnhouse,Sportgamehouse,minimap,knowNPCdieText,humanEnemy,notes8,savenpc1,w_AXEplayer;
public Save save;
    void Update(){
        if(Input.GetKeyDown(KeyCode.Return)&&save.w_AXE>0|| Input.GetKeyDown(KeyCode.E) && save.w_AXE > 0)
        {
            w_AXEplayer.transform.position=new Vector3(323.76f,31.684f,280.1f);
            w_AXEplayer.transform.rotation=Quaternion.Euler(0f,91.562f,0f);
            opendoorsound.Play();
            mmpointer.SetActive(true);
            Destroy(Mathselearnhouse);
            Destroy(Sportgamehouse);
            minimap.SetActive(true);
            knowNPCdieText.SetActive(true);
            humanEnemy.SetActive(true);
            notes8.SetActive(true);
            this.gameObject.SetActive(false);
            Destroy(savenpc1);
        }
    }
}