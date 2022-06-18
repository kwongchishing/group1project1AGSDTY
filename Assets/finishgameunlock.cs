using UnityEngine;public class finishgameunlock:MonoBehaviour{
    public GameObject finalbossscene,entertocontinue2,bgm1,finalbossfightbgm,finishgametalk1,prisonscene,player,sister,sisterdoor,sisterdooropened,talkwithsisterDistance;
    public AudioSource castledooropen;
    void Update(){
        if(Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.E))
        {
            Destroy(finishgametalk1);
            prisonscene.SetActive(true);
            player.transform.position=new Vector3(-509.707642f,372.032501f,-1584.64111f);
            player.transform.rotation=Quaternion.Euler(0,98.6845932f,0);
            player.transform.LookAt(new Vector3(sister.transform.position.x,player.transform.position.y,sister.transform.position.z));
            Destroy(sisterdoor);
            sisterdooropened.SetActive(true);
            Destroy(finalbossfightbgm);
            bgm1.SetActive(true);
            if(talkwithsisterDistance!=null) Destroy(talkwithsisterDistance);            
            finalbossscene.SetActive(false);
            castledooropen.Play();
            Destroy(this.gameObject);entertocontinue2.SetActive(true);
        }
    }
}