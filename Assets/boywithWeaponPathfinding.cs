using UnityEngine;using UnityEngine.AI;public class boywithWeaponPathfinding:MonoBehaviour{
	NavMeshAgent NM;
	Transform Player;
	public Transform thisenemy;
	Animator anim;
	public GameObject Weapon;public AudioSource foundplayer,fightsound;
	void Start(){
		NM=GetComponent<NavMeshAgent>();
		anim=GetComponent<Animator>();
	}
	void Update(){
		Player=GameObject.FindWithTag("Player").transform;
		if(Vector3.Distance(Player.transform.position,thisenemy.transform.position)<=8.5f && !anim.GetCurrentAnimatorStateInfo(0).IsName("boygethit")|| Vector3.Distance(Player.transform.position, thisenemy.transform.position) <= 8.5f && !anim.GetCurrentAnimatorStateInfo(0).IsName("auntgethit"))
		{
			transform.LookAt(new Vector3(Player.transform.position.x,transform.position.y,Player.transform.position.z));
			anim.SetBool("walk",true);NM.enabled = true;
			NM.SetDestination(Player.position);
		}
		if (Vector3.Distance(Player.transform.position,transform.position)<1.77f){
			anim.SetTrigger("attack");
		}
		if (Vector3.Distance(Player.transform.position, thisenemy.transform.position)>8.5f){
			anim.SetBool("walk",true);
			transform.LookAt(new Vector3(thisenemy.transform.position.x,transform.position.y,thisenemy.transform.position.z)); NM.enabled = true;
			NM.SetDestination(thisenemy.position);
		}
		if(Vector3.Distance(transform.position,thisenemy.transform.position)<=1.55f&&Vector3.Distance(Player.transform.position,thisenemy.transform.position)>8.5f){
			anim.SetBool("walk",false); NM.enabled = false;
		}
		if(Vector3.Distance(Player.transform.position,transform.position)<7.5f&&Vector3.Distance(Player.transform.position,transform.position)>7.1f){
			foundplayer.Play();
		}
	}
	public void attackopenCol(){
		Weapon.GetComponent<MeshCollider>().enabled=true;fightsound.Play();
	}
	public void attackcloseCol(){
		Weapon.GetComponent<MeshCollider>().enabled=false;		
	}
	public void NMclose(){
		NM.enabled=false;
		Weapon.GetComponent<MeshCollider>().enabled=false;
	}
	public void NMopen(){
		NM.enabled=true;
	}
}