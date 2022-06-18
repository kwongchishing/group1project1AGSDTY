using UnityEngine;public class gotocreditsup:MonoBehaviour{
    public GameObject bgm1,mixbgmcredit,creditsup;
    void Update(){
        if(Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.E))
        {
            bgm1.SetActive(false);
            creditsup.SetActive(true);
            mixbgmcredit.SetActive(true);
            Destroy(this.gameObject);
        }
    }
}