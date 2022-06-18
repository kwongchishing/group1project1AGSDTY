using UnityEngine;public class OldmanEnemy_Pathfinding:MonoBehaviour{
	public Transform Player;
	Animator anim; public WAXE_exp exp; public save2 save2; public Oldman_EnemyHealth Oldman_EnemyHealth;
	public GameObject WeaponrightLeg,foundPlayer,Arrow;
	public AudioSource Oldman_attack1,die;
	void Start(){
		anim=GetComponent<Animator>();
	}
	void Update(){
		if(Vector3.Distance(Player.transform.position, transform.position)<=2.1f){
			anim.ResetTrigger("shoot");anim.SetBool("Drawing",false);anim.SetTrigger("kickattack");
			Arrow.GetComponent<BoxCollider>().enabled=false;
		}
		if(Vector3.Distance(Player.transform.position,transform.position)>2.1f&&Vector3.Distance(Player.transform.position,transform.position)<11f){
			 Arrow.GetComponent<BoxCollider>().enabled=true;
			anim.ResetTrigger("kickattack");			
			if(Oldman_EnemyHealth.currentHealth>0) transform.LookAt(new Vector3(Player.transform.position.x,transform.position.y,Player.transform.position.z));
			anim.SetTrigger("shoot");
		}
		if(Vector3.Distance(Player.transform.position,transform.position)>11f){
		}
	}
	public void ShootStart(){
		anim.SetBool("Drawing",true); anim.ResetTrigger("kickattack"); foundPlayer.SetActive(true);
	}

public void ShootEnd(){
		anim.SetBool("Drawing",false);
	}
		public void OldmankickStart(){		 
		transform.LookAt(new Vector3(Player.transform.position.x,transform.position.y,Player.transform.position.z));		
		WeaponrightLeg.GetComponent<BoxCollider>().enabled=true; foundPlayer.SetActive(false);
	}
	public void AttackSoundPlay(){
		Oldman_attack1.Play();
	}
	public void OldmankickEnd(){
		WeaponrightLeg.GetComponent<BoxCollider>().enabled=false;
	}
	public void dieStart(){
		die.Play(); 
		exp.currentExp+=200;
		save2.currentMoney=save2.currentMoney+Oldman_EnemyHealth.dropmoney;
		save2.goodbadcount++;
	}
	public void dieEnd(){
		Destroy(this.gameObject,0.2f);
	}	
}