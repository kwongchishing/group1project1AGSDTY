using UnityEngine;public class checkSportHouseTEXT1:MonoBehaviour{
    public GameObject checkSportHouseTEXT2;
    void Update(){
        if(Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.E))
        {
            checkSportHouseTEXT2.SetActive(true);
            this.gameObject.SetActive(false);}}}