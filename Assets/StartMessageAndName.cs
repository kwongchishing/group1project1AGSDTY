using UnityEngine;using UnityEngine.UI;public class StartMessageAndName:MonoBehaviour{
    public static string playernamestr;
    public Text playername;
    public GameObject Playericon,HealthBar,expbar,Starttext,miniMap,potionCount,playerName,moneyicon,GoodBadCountBar,punchUI;
    private void OnTriggerExit(Collider other){
        if(PlayerPrefs.HasKey("name")){
            Playericon.SetActive(true);HealthBar.SetActive(true);
            Starttext.SetActive(false);miniMap.SetActive(true);
            expbar.SetActive(true);potionCount.SetActive(true);
            playerName.SetActive(true);moneyicon.SetActive(true);GoodBadCountBar.SetActive(true); punchUI.SetActive(true); Destroy(this.gameObject);
        }
        else{   playername.text=playernamestr;
            playerName.SetActive(true);Playericon.SetActive(true);
            HealthBar.SetActive(true);Starttext.SetActive(false);
            expbar.SetActive(true);miniMap.SetActive(true);
            potionCount.SetActive(true);moneyicon.SetActive(true); GoodBadCountBar.SetActive(true); punchUI.SetActive(true); Destroy(this.gameObject);
        }
    }}