using UnityEngine;public class destroypanelwhite:MonoBehaviour{
    public GameObject Player,Allwhitepanel,dragonsaveplayer;
    void Start(){Destroy(this.gameObject,2f);}
    public void showAllwhitepanel(){
        Allwhitepanel.SetActive(true);
        Player.gameObject.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl>().enabled=false;
        Player.transform.position=new Vector3(389.171387f,35.8205147f,302.225433f);
        Player.transform.rotation=Quaternion.Euler(0f,352.489929f,0f);
        dragonsaveplayer.SetActive(true);
        Player.GetComponent<Rigidbody>().constraints=RigidbodyConstraints.FreezePositionX|RigidbodyConstraints.FreezePositionZ|RigidbodyConstraints.FreezeRotationX|RigidbodyConstraints.FreezeRotationY|RigidbodyConstraints.FreezeRotationZ;
        Player.GetComponent<Animator>().SetBool("stop",true);}}