using UnityEngine;public class lookatsavenpcrunning:MonoBehaviour{
    public Transform savenpcemptyobject;
    void Update(){
        transform.LookAt(new Vector3(savenpcemptyobject.transform.position.x, savenpcemptyobject.transform.position.y, savenpcemptyobject.transform.position.z));
    }
}