using UnityEngine;public class startrunningGame:MonoBehaviour{
    public GameObject runningwaypoint,AXE, player,runningGamefunction,runningtext1,disappearLa,boss1fightsound,leaveCollider,boss1rotateSound;
    public AXE_lighting AXE_lighting;
    Animator anim;
    void Start(){anim=player.GetComponent<Animator>(); }
    void Update(){
        if(Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.E))
        {
            runningGamefunction.SetActive(true);boss1rotateSound.SetActive(false);leaveCollider.SetActive(true);AXE_lighting.lighting=false;
            AXE_lighting.heavying=false;
            AXE.GetComponent<MeshCollider>().enabled=false;
            player.transform.position=new Vector3(3103.10596f,22.65515f,1098.90979f);
            player.transform.rotation=Quaternion.Euler(0,178.727982f,0);
            anim.SetBool("stop",false);
            player.GetComponent<Rigidbody>().constraints=RigidbodyConstraints.FreezeRotationX|RigidbodyConstraints.FreezeRotationY|RigidbodyConstraints.FreezeRotationZ;
            player.gameObject.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl>().enabled=true;
            runningtext1.SetActive(true);
            runningwaypoint.SetActive(true);
            Destroy(disappearLa);                  
            Destroy(boss1fightsound); 
            Destroy(this.gameObject);
        }
    }
}