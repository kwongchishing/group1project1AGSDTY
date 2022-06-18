using UnityEngine;using UnityEngine.AI;public class humanmaleenemy2:MonoBehaviour{
	NavMeshAgent NM;
	Transform Player; public Transform thisenemy;
	Animator anim;
	public humanShieldEnemyHP humanShieldEnemyHP;
	public GameObject Weapon;public AudioSource foundPlayer,Shieldmanattacksound;
	void Start(){
		NM=GetComponent<NavMeshAgent>();
		anim=GetComponent<Animator>();
	}
	void Update(){
		if(Player==null) Player=GameObject.FindWithTag("Player").transform;
		if(Vector3.Distance(Player.transform.position,thisenemy.transform.position)<=11f && !anim.GetCurrentAnimatorStateInfo(0).IsName("getHit"))
		{
			if(humanShieldEnemyHP.currentHealth>0){transform.LookAt(new Vector3(Player.transform.position.x,transform.position.y,Player.transform.position.z));}
			anim.SetBool("walk",true); NM.enabled = true;
			NM.SetDestination(Player.position);
		}
		if(Vector3.Distance(Player.transform.position,transform.position)<1.8f){
			NM.enabled = false; anim.SetTrigger("attack");
		}
		if(Vector3.Distance(Player.transform.position,thisenemy.transform.position)>11f){
			anim.SetBool("walk",true);
			transform.LookAt(new Vector3(thisenemy.transform.position.x, transform.position.y, thisenemy.transform.position.z));
			NM.enabled = true;
			NM.SetDestination(thisenemy.position);
		}
		if(Vector3.Distance(transform.position,thisenemy.transform.position)<=1.8f&&Vector3.Distance(Player.transform.position,thisenemy.transform.position)>11f){
			anim.SetBool("walk",false); NM.enabled = false;
		}
		if(Vector3.Distance(Player.transform.position,transform.position)<10f&&Vector3.Distance(Player.transform.position,transform.position)>9.5f){
			foundPlayer.Play();
		}
	}	
	public void attackopenCol(){
		NM.enabled = false; Weapon.GetComponent<MeshCollider>().enabled=true; Shieldmanattacksound.Play();
	}
	public void attackcloseCol(){
		NM.enabled = true; Weapon.GetComponent<MeshCollider>().enabled=false;}
	public void nmclose()
    {
		NM.enabled = false;
	}
	public void nmopen()
	{
		NM.enabled = true;
	}
}