using UnityEngine;public class transferWeaponhousesister:MonoBehaviour{
    public GameObject Player2;
    public float distance;
    public Transform p1,p2;
    public save2 save2;
    public AudioSource opendoorsound;
    public GameObject newbgm1,weaponbgm,Player1;
    void Update(){
        distance=Vector3.Distance(p1.transform.position,p2.transform.position);
        if(Input.GetKeyDown(KeyCode.KeypadEnter)){
            opendoorsound.Play();
            Player2.transform.position=new Vector3(-211.01437377929688f, -138.77f, 122.89533233642578f);
            save2.isinshop=true;
            if(distance<=8f){
                Player1.transform.position=new Vector3(-207.95802307128907f, -138.77f, 122.84185791015625f);
                save2.isinshop=true;
                newbgm1.SetActive(false);
                weaponbgm.SetActive(true);
            }
        }
    }
}