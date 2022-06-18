using UnityEngine;public class getdodgeAndiron:MonoBehaviour{
    public GameObject getiron,getDodge;
    public AudioSource GetdodgeAndiron,test2music;
    public Save save;
       void Update(){
        test2music.Stop();
        if(Input.GetKeyDown(KeyCode.Return)|| Input.GetKeyDown(KeyCode.E))
        {
            GetdodgeAndiron.Play();
            getDodge.SetActive(true);
            getiron.SetActive(true);
            save.getDodge+=1;
            Destroy(this.gameObject);}}}