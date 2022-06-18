using UnityEngine;using UnityEngine.AI;public class unclePathFinding:MonoBehaviour{
    NavMeshAgent NM;
    Transform Player;
	public Transform thisenemy;
    Animator anim;
	public GameObject attacklefthand;public AudioSource foundplayer,fightsound;
    void Start(){
        NM=GetComponent<NavMeshAgent>();
        anim=GetComponent<Animator>();		
	}
    void Update(){
        Player=GameObject.FindWithTag("Player").transform;
		if(Vector3.Distance(Player.transform.position,thisenemy.transform.position)<=11f&& !anim.GetCurrentAnimatorStateInfo(0).IsName("getHit"))
		{
			transform.LookAt(new Vector3(Player.transform.position.x,transform.position.y,Player.transform.position.z));
			anim.SetBool("walk",true); NM.enabled = true;
			NM.SetDestination(Player.position);
		}
		if(Vector3.Distance(Player.transform.position,transform.position)<1.44f){
			anim.SetTrigger("attack");
		}
		if(Vector3.Distance(Player.transform.position,thisenemy.transform.position)>11f&& Vector3.Distance(transform.position, thisenemy.transform.position) > 1.8f)
		{
			anim.SetBool("walk", true);
			transform.LookAt(new Vector3(thisenemy.transform.position.x,transform.position.y,thisenemy.transform.position.z)); NM.enabled = true;
			NM.SetDestination(thisenemy.position);
		}
		if(Vector3.Distance(transform.position,thisenemy.transform.position)<=1.8f&&Vector3.Distance(Player.transform.position,thisenemy.transform.position)>11f){
			anim.SetBool("walk", false); NM.enabled = false;
		}
		if(Vector3.Distance(Player.transform.position,transform.position)<10f&&Vector3.Distance(Player.transform.position,transform.position)>9.5f){
			foundplayer.Play();
		}
	}	
	public void attackplayer(){
		attacklefthand.SetActive(true);fightsound.Play();
	}
	public void attackplayerend(){
		attacklefthand.SetActive(false);
    }
	public void NMclose(){
		NM.enabled=false; attacklefthand.SetActive(false);
	}
	public void NMopen(){
		NM.enabled=true;
	}
}