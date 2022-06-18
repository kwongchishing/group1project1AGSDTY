using UnityEngine;using UnityEngine.UI;using UnityEngine.SceneManagement;public class countFunctionTimerun:MonoBehaviour{
    public float currentTime=0f;
    public float startingTime=50f;
    public Text runcountText;
    void Start(){
        currentTime=startingTime;
    }
    void Update(){
        currentTime-=1*Time.deltaTime;
        runcountText.text=currentTime.ToString("0");
        if(currentTime<=0){
            currentTime=0;
            Time.timeScale=0;
            SceneManager.LoadScene("playerdie");
        }
    }
}