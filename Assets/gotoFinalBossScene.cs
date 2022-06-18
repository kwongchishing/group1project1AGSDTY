using UnityEngine;public class gotoFinalBossScene:MonoBehaviour{
    public GameObject player,finalbossscene,prison,prisonbgm,finalbossscenebgm,Canvas;
    public AudioSource opencastledoorSound;
    void Update(){
        if(Input.GetKeyDown(KeyCode.Return)&&player.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Grounded")|| Input.GetKeyDown(KeyCode.E) && player.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Grounded"))
        {            
            player.GetComponent<Animator>().SetBool("stop",true);
            finalbossscene.SetActive(true);
            player.transform.position=new Vector3(2343.97876f,1206.19861f,-3012.2688f);
            player.transform.rotation=Quaternion.Euler(0,2.722f,0);
            opencastledoorSound.Play(); prisonbgm.SetActive(false);
            prison.SetActive(false);finalbossscenebgm.SetActive(true);
             Canvas.SetActive(true);
        }
    }
}