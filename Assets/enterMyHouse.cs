using UnityEngine;public class enterMyHouse:MonoBehaviour{
    public GameObject myhouse,minimap;
    public AudioSource bg1, bg2;
    public save2 save2;
    public Ischange Ischange;
    void Update(){
        if(Input.GetKeyDown(KeyCode.Return)){
            myhouse.SetActive(true);
            GameObject.FindWithTag("Player").transform.position = new Vector3(508.510345f, 50.3933533f, 212.40213f);
            minimap.SetActive(false);
            if (Ischange.ischange < 1)
            {
                bg1.Stop();
            }
            if (Ischange.ischange > 0 && save2.collectedkey < 1)
            {
                bg2.Stop();
            }
            if (Ischange.ischange > 0 && save2.collectedkey > 0)
            {
                bg1.Stop();
            }
        }
    }
}
