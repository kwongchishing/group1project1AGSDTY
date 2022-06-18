using UnityEngine;public class lookatmainmission2arrow:MonoBehaviour{
    public save2 save2;
    public GameObject well2,well3,well4,welltotunnel,UGwell, mainGate,Ostonehouse,Ostoneplace, Ostone;
    void Update(){
        if(save2.collectedkey<1) transform.LookAt(new Vector3(UGwell.transform.position.x,UGwell.transform.position.y,UGwell.transform.position.z));
        if(save2.collectedkey>1) transform.LookAt(new Vector3(mainGate.transform.position.x,mainGate.transform.position.y,mainGate.transform.position.z));
        if(save2.gateopened>0&&save2.letterOstone<1) transform.LookAt(new Vector3(Ostonehouse.transform.position.x,Ostonehouse.transform.position.y,Ostonehouse.transform.position.z));
        if(save2.finishBombgame>0&&save2.letterOstone<1) transform.LookAt(new Vector3(Ostone.transform.position.x,Ostone.transform.position.y,Ostone.transform.position.z));
        if(save2.letterOstone>0&&save2.finishOstone<1) transform.LookAt(new Vector3(Ostoneplace.transform.position.x,Ostoneplace.transform.position.y,Ostoneplace.transform.position.z));
        if(save2.finishOstone>0&&save2.finishPstone<1) this.gameObject.SetActive(false);
        if(save2.finishOstone>0&&save2.finishPstone>0&&save2.clearwell2<1&&save2.clearwell3<1&&save2.clearwell4<1) transform.LookAt(new Vector3(welltotunnel.transform.position.x,welltotunnel.transform.position.y,welltotunnel.transform.position.z));
        if(save2.clearwell4>0&&Vector3.Distance(this.gameObject.transform.position,well4.transform.position)<35f){
            transform.LookAt(new Vector3(well4.transform.position.x,well4.transform.position.y,well4.transform.position.z));
        }
        if(save2.clearwell2>0&&Vector3.Distance(this.gameObject.transform.position,well2.transform.position)<19f){
            transform.LookAt(new Vector3(well2.transform.position.x,well2.transform.position.y,well2.transform.position.z));
        }
        if(save2.clearwell3>0&&Vector3.Distance(this.gameObject.transform.position,well3.transform.position)<19f){
            transform.LookAt(new Vector3(well3.transform.position.x,well3.transform.position.y,well3.transform.position.z));
        }
        if(save2.finishOstone>0&save2.finishPstone>0&&Vector3.Distance(this.gameObject.transform.position,welltotunnel.transform.position)<27f&&save2.clearwell2>0|save2.clearwell3>0|save2.clearwell4>0){
            transform.LookAt(new Vector3(welltotunnel.transform.position.x,welltotunnel.transform.position.y,welltotunnel.transform.position.z));
        }
    }
}