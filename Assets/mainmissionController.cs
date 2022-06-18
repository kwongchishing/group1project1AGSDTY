using UnityEngine;using UnityEngine.UI;public class mainmissionController:MonoBehaviour{
   public GameObject mainmissionscript,additionalmissionscript,additionalmissionbutton;
    public void clickmainmission(){
        mainmissionscript.SetActive(true);
        additionalmissionscript.SetActive(false);
        additionalmissionbutton.GetComponent<Image>().color=Color.white;
        GetComponent<Image>().color=Color.black;
    }
}