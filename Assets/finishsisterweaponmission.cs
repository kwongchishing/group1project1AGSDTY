using UnityEngine;public class finishsisterweaponmission:MonoBehaviour{
    public save2 save2;
    public WAXE_exp WAXE_exp;
    public GameObject sisterweaponminimapicon,leavecanvas, talkgetweaponCanvas, door, swordinhandwait,swordinhandP2;
    void Start(){
        swordinhandwait.SetActive(true);
        swordinhandP2.SetActive(true);
        save2.sisterweapon++;
        WAXE_exp.currentExp+=200;
    }
    void Update(){
        if(Input.GetKeyDown(KeyCode.Return)||Input.GetKeyDown(KeyCode.E)){
            door.GetComponent<SphereCollider>().enabled=true;
            leavecanvas.SetActive(true);
            Destroy(talkgetweaponCanvas);
            Destroy(sisterweaponminimapicon);
        }
    }
}