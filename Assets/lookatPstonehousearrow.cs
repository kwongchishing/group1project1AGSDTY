using UnityEngine;public class lookatPstonehousearrow:MonoBehaviour{
    public save2 save2;
    public GameObject Pstonehouse,Pstoneplace;
    void Update(){
        if(save2.letterPstone<1) transform.LookAt(new Vector3(Pstonehouse.transform.position.x,Pstonehouse.transform.position.y,Pstonehouse.transform.position.z));
        if(save2.letterPstone>0&&save2.finishPstone<1) transform.LookAt(new Vector3(Pstoneplace.transform.position.x,Pstoneplace.transform.position.y,Pstoneplace.transform.position.z));
        if(save2.finishPstone>0) Destroy(this.gameObject);
    }
}