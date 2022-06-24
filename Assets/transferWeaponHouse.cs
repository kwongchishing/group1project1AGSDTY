using UnityEngine;public class transferWeaponHouse:MonoBehaviour{
    public AudioSource opendoorsound;
    public save2 save2;
    public float distance;
    public Transform p1,p2;
    public GameObject minimap,Player,Player2;
    void Update(){
        distance=Vector3.Distance(p1.transform.position,p2.transform.position);
        if(Input.GetKeyDown(KeyCode.Return)||Input.GetKeyDown(KeyCode.E)){
            opendoorsound.Play();
            Player.transform.position=new Vector3(-207.95802307128907f, -138.77f, 122.84185791015625f);
            save2.isinshop=true;
            minimap.SetActive(false);
            if(distance<=8f&&save2.isjoined==true){
                save2.isinshop=true;
                Player2.transform.position=new Vector3(-211.01437377929688f, -138.77f, 122.89533233642578f);
            }
        }
    }
}