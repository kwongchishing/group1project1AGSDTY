using UnityEngine;public class checkmathsNPCdie:MonoBehaviour{
    public GameObject mathNPCIsdieText;
    void Update(){
        if(Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.E))
        {
            mathNPCIsdieText.SetActive(true);
            this.gameObject.SetActive(false);}}}