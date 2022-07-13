using UnityEngine;public class transferTokillfather:MonoBehaviour{
    public GameObject Dlight,fathertalk, finalboss2scene, Player, Player2,newbgm1,newbgm2;
    void Update(){
        if(Input.GetKeyDown(KeyCode.E)||Input.GetKeyDown(KeyCode.Return)){
            finalboss2scene.SetActive(true);
            Player.transform.position = new Vector3(143.265167f,-212.7f,-2962.41211f);
            Player2.transform.position= new Vector3(141f,-212.7f,-2960.948242f);
            newbgm1.SetActive(false);
            newbgm2.SetActive(true);
            fathertalk.SetActive(true);
            Dlight.SetActive(false);
            Dlight.SetActive(true);
        }
    }
}