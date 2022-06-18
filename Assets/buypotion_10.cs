using UnityEngine;public class buypotion_10:MonoBehaviour{
    public save2 save2;
    public AudioSource noitemSound,getitemSound,cashoutSound;
   public void buypotion(){
        if(save2.currentMoney<10){noitemSound.Play();}
        if(save2.currentMoney>=10){
            save2.currentMoney-=10;
            save2.currentpotion++;
            getitemSound.Play(); cashoutSound.Play();
        }}}