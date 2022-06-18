using UnityEngine;public class CollectLetterPstone:MonoBehaviour{
    public GameObject LetterPstone,GetPStone,minimapiconPstone,All_powerfulGuard;
    public AudioSource getitemSound;
    public save2 save2;
    void Update(){
        if(Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.E))
        {
            save2.letterPstone++;
            GetPStone.SetActive(true);
            getitemSound.Play();
            All_powerfulGuard.SetActive(true);
            Destroy(GetPStone,3f);
            Destroy(LetterPstone);
            Destroy(minimapiconPstone);
        }
    }
}