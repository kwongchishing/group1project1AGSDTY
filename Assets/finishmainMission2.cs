using UnityEngine;public class finishmainMission2:MonoBehaviour{
    public AudioSource runninggameSound,bgm1;
    public GameObject runningwaypoint,AXE, All_turtle, SDBDfile,bgmusic1,mmpointer,TimecountText,player,Timecount,humanenemyset2,humanenemy,runningGamePlace,saveNPCforkillboss,save2NPC,minimap,DirectionalLight,minimapiconKey;
    void Start(){
        player.GetComponent<Animator>().SetBool("stop",false);
        player.GetComponent<Rigidbody>().constraints=RigidbodyConstraints.FreezeRotationX|RigidbodyConstraints.FreezeRotationY|RigidbodyConstraints.FreezeRotationZ;
        player.gameObject.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl>().enabled=true;        
        Destroy(this.gameObject,2f);
        mmpointer.SetActive(true);
        Destroy(humanenemy);
        runninggameSound.Stop();
        humanenemyset2.SetActive(true);
        bgmusic1.SetActive(true);bgm1.Play();
        AXE.GetComponent<MeshCollider>().enabled=true;
        Destroy(TimecountText);
        Destroy(Timecount);
        Destroy(runningGamePlace);
        Destroy(saveNPCforkillboss);
        save2NPC.transform.position=new Vector3(395.235107f,29.3612156f,315.978302f); All_turtle.SetActive(true);
        minimap.SetActive(true); DirectionalLight.GetComponent<Light>().intensity=1.1f; Destroy(minimapiconKey);Destroy(SDBDfile);
        Destroy(runningwaypoint);
    }
}