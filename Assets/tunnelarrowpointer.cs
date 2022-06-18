using UnityEngine;public class tunnelarrowpointer:MonoBehaviour{
    public GameObject doorprison;
    void Update(){
        transform.LookAt(new Vector3(doorprison.transform.position.x,doorprison.transform.position.y,doorprison.transform.position.z));
    }
}