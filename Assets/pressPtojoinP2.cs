using UnityEngine;public class pressPtojoinP2:MonoBehaviour{
    public GameObject minimapcamera,minimap,footstepRoad,sisterwaitforjoin,sister,mecamera,splitcamera;
    public save2 save2;
    void Update(){
        if(Input.GetKeyDown(KeyCode.Return)|| Input.GetKeyDown(KeyCode.E))
        {
            sister.SetActive(true);
            splitcamera.SetActive(true);
            mecamera.transform.SetParent(null);            
            save2.isjoined=true;
            footstepRoad.SetActive(false);
            minimapcamera.SetActive(false);
            mecamera.transform.rotation=Quaternion.Euler(0,0,0);
            sisterwaitforjoin.SetActive(false);
            mecamera.SetActive(false);
            this.gameObject.SetActive(false);
        }
    }
}