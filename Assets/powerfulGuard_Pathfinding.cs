using UnityEngine;using UnityEngine.AI;public class powerfulGuard_Pathfinding:MonoBehaviour{
	NavMeshAgent NM;
	public Transform Player;
	public Transform thisenemy;
	Animator anim; public WAXE_exp exp; public save2 save2; public powerfulguard_EnemyHealth powerfulguard_EnemyHealth;
	public int attackmode=0;
	public GameObject Weapon,Weaponheavy;
	public AudioSource guard_attack1,guard_attack2,die,foundPlayer;
	void Start(){
		NM=GetComponent<NavMeshAgent>();
		anim=GetComponent<Animator>();
	}
	void Update(){
		if(Player==null) Player=GameObject.FindWithTag("Player").transform;
		if(Vector3.Distance(Player.transform.position,thisenemy.transform.position)<=11f){
			if(powerfulguard_EnemyHealth.currentHealth>0){transform.LookAt(new Vector3(Player.transform.position.x, transform.position.y, Player.transform.position.z)); }
			anim.SetBool("walk",true);
			NM.SetDestination(Player.position);
		}
		if(Vector3.Distance(Player.transform.position,transform.position)<1.8f){
			if(attackmode==0){
				attackmode=Random.Range(1,3);
				if(attackmode==1){anim.SetTrigger("attack1");}
				else{anim.SetTrigger("attack2");}
			}
		}
		if(Vector3.Distance(Player.transform.position,thisenemy.transform.position)>11f){
			anim.SetBool("walk",true);
			attackmode=0;
			transform.LookAt(new Vector3(thisenemy.transform.position.x,transform.position.y,thisenemy.transform.position.z));
			NM.SetDestination(thisenemy.position);
		}
		if(Vector3.Distance(transform.position,thisenemy.transform.position)<=1.8f&&Vector3.Distance(Player.transform.position,thisenemy.transform.position)>11f){
			anim.SetBool("walk",false);
			attackmode=0;
		}
		if(Vector3.Distance(Player.transform.position,transform.position)<10f&&Vector3.Distance(Player.transform.position,transform.position)>9.5f){
			foundPlayer.Play();
		}
	}
	public void powerfulguardattackopenCol(){
		NM.enabled=false; guard_attack1.Play();
		Weapon.GetComponent<BoxCollider>().enabled=true; attackmode=6;
	}
	public void powerfulguardattackcloseCol(){
		Weapon.GetComponent<BoxCollider>().enabled=false; attackmode=0;
	}
	public void powerfulguardheavyattackopenCol(){
		NM.enabled=false; guard_attack2.Play();
		Weaponheavy.GetComponent<BoxCollider>().enabled=true; attackmode=6;
	}
	public void powerfulguardheavyattackcloseCol(){
		Weaponheavy.GetComponent<BoxCollider>().enabled=false; attackmode=0;
	}
	public void powerfuldieStart(){
		die.Play();attackmode=6;
		exp.currentExp+=220;
		save2.currentMoney=save2.currentMoney+powerfulguard_EnemyHealth.dropmoney;
		save2.goodbadcount++;
	}
	public void powerfuldieEnd(){
		Destroy(this.gameObject,0.3f);
	}
	public void powerfulgethit(){
		attackmode=6;NM.enabled=false;
	}
	public void powerfulgethitEnd(){
		attackmode=0;NM.enabled=true;
	}
	public void powerfulwalk(){
		attackmode=0;NM.enabled=true;
	}
}