using UnityEngine;public class transferPlayerfinalbossscene:MonoBehaviour{
    public GameObject player, talk4textbeforbossfight;
    public Transform finalboss,Me_withAXE,finalbossdragon;
    void Update(){
        if (Input.GetKeyDown(KeyCode.Return)|| Input.GetKeyDown(KeyCode.E))
        {
            player.transform.position=new Vector3(2346.66992f,1206.19861f,-2993.58008f);
            player.transform.rotation=Quaternion.Euler(0,228.649063f,0);
            finalboss.transform.LookAt(new Vector3(Me_withAXE.transform.position.x,finalboss.transform.position.y,Me_withAXE.transform.position.z));
            finalbossdragon.transform.LookAt(new Vector3(Me_withAXE.transform.position.x,finalbossdragon.transform.position.y,Me_withAXE.transform.position.z));
            talk4textbeforbossfight.SetActive(true);            
            Destroy(this.gameObject);
        }
    }
}