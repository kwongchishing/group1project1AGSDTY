using UnityEngine;using UnityEngine.UI;public class additionalmissionController:MonoBehaviour{
    public GameObject mainmissionscript,additionalmissionscript, mainmission1descript,mainmissionbutton;
    public void clickAdditional(){
        additionalmissionscript.SetActive(true);
        mainmissionscript.SetActive(false);
        GetComponent<Image>().color=Color.black;
        mainmissionbutton.GetComponent<Image>().color=Color.white;
        mainmission1descript.SetActive(false);
    }
}
