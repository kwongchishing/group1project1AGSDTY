using UnityEngine;public class collectLetterOstone:MonoBehaviour{
    public GameObject LetterOstone,GetOStone, AllOldManEnemy,bg3,bg4;
    public AudioSource getitemSound,OldmanfoundPlayer;
    public save2 save2;
    void Update(){
        if(Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.E))
        {
            save2.letterOstone++;
            GetOStone.SetActive(true);
            getitemSound.Play();
            Destroy(GetOStone,5f);
            AllOldManEnemy.SetActive(true);
            OldmanfoundPlayer.Play();
            bg3.SetActive(false);bg4.SetActive(true);
            Destroy(LetterOstone);
        }
    }
}