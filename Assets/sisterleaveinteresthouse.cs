using UnityEngine;public class sisterleaveinteresthouse:MonoBehaviour{
    public GameObject Player1, Player2;
    public float distance;
    public Transform p1,p2;
    public AudioSource opendoorsound;
    public save2 save2;
    void Update()
    {
        distance = Vector3.Distance(p1.transform.position, p2.transform.position);
        if (Input.GetKeyDown(KeyCode.KeypadEnter) && distance > 20f)
        {
            Player2.transform.position = new Vector3(352.682892f, 29.8205147f, 292.016449f);
            opendoorsound.Play();
            save2.isinshop = false;
            this.gameObject.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.KeypadEnter) && distance <= 20f)
        {
            Player1.transform.position = new Vector3(352.914429f, 29.862154f, 295.866608f);
            Player2.transform.position = new Vector3(352.682892f, 29.8205147f, 292.016449f);
            opendoorsound.Play();
            save2.isinshop = false;
            this.gameObject.SetActive(false);
        }
    }
}