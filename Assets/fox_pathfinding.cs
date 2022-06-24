using UnityEngine;using UnityEngine.AI;public class fox_pathfinding:MonoBehaviour{
	NavMeshAgent NM;
	public Transform Player2,Player,thisenemy,chan;
	Animator anim; public WAXE_exp exp;public save2 save2; public fox_EnemyHealth Bull_EnemyHealth;
	public int attackmode=0;
	public GameObject missionsuccesscanvas,finishmissioncanvas, All_colliderwall, Weapon;
	public AudioSource Bull_attack12,Bulldieing;
	bool trig;
	void Start(){
		NM=GetComponent<NavMeshAgent>();
		anim=GetComponent<Animator>();
	}
	void Update(){
		if(Vector3.Distance(Player.transform.position,thisenemy.transform.position)<=16f){
			if(Bull_EnemyHealth.currentHealth>0){transform.LookAt(new Vector3(Player.transform.position.x, transform.position.y, Player.transform.position.z));}
			anim.SetBool("walk",true);
			NM.SetDestination(Player.position);
			attackmode=0;
		}
		if(Vector3.Distance(Player2.transform.position,thisenemy.transform.position)<=16f){
			if(Bull_EnemyHealth.currentHealth>0){transform.LookAt(new Vector3(Player2.transform.position.x,transform.position.y,Player2.transform.position.z));}
			anim.SetBool("walk", true);
			NM.SetDestination(Player2.position);
			attackmode=0;
		}
		if(Vector3.Distance(Player.transform.position,thisenemy.transform.position)<=16f&&Vector3.Distance(Player2.transform.position,thisenemy.transform.position)<=16f){
			if(Vector3.Distance(Player.transform.position,transform.position)<Vector3.Distance(Player2.transform.position,transform.position)){
				if(Bull_EnemyHealth.currentHealth>0){transform.LookAt(new Vector3(Player.transform.position.x,transform.position.y,Player.transform.position.z));}
				anim.SetBool("walk",true);
				NM.SetDestination(Player.position);
				attackmode=0;
			}
		}
		if(Vector3.Distance(Player.transform.position,thisenemy.transform.position)<=16f&&Vector3.Distance(Player2.transform.position,thisenemy.transform.position)<=16f){
			if(Vector3.Distance(Player.transform.position,transform.position)>Vector3.Distance(Player2.transform.position,transform.position)){
				if(Bull_EnemyHealth.currentHealth>0){transform.LookAt(new Vector3(Player2.transform.position.x,transform.position.y,Player2.transform.position.z));}
				anim.SetBool("walk",true);
				NM.SetDestination(Player2.position);
				attackmode=0;
			}
		}
		if(Vector3.Distance(Player.transform.position,transform.position)<2.5f){
			if(attackmode==0){
				attackmode=Random.Range(1,5);
				if(attackmode==1){anim.SetTrigger("attack1");}
				else if(attackmode==2){anim.SetTrigger("attack2");}
				else if(attackmode==3){anim.SetTrigger("attack3");}
				else{anim.SetTrigger("attack4");}
			}
		}
		if(Vector3.Distance(Player2.transform.position,transform.position)<2.5f){
			if(attackmode==0){
				attackmode=Random.Range(1,5);
				if(attackmode==1){anim.SetTrigger("attack1");}
				else if(attackmode==2){anim.SetTrigger("attack2");}
				else if(attackmode==3){anim.SetTrigger("attack3");}
				else{anim.SetTrigger("attack4");}
			}
		}
		if(Vector3.Distance(Player.transform.position,thisenemy.transform.position)>16f&&Vector3.Distance(Player2.transform.position,thisenemy.transform.position)>16f){
			anim.SetBool("walk",true);
			attackmode=6;
			if(Bull_EnemyHealth.currentHealth>0){
				transform.LookAt(new Vector3(thisenemy.transform.position.x,transform.position.y,thisenemy.transform.position.z));
			}
			NM.SetDestination(thisenemy.position);
			anim.ResetTrigger("attack1");
			anim.ResetTrigger("attack2");
			anim.ResetTrigger("attack3");
			anim.ResetTrigger("attack4");
		}		
		if(Vector3.Distance(transform.position,thisenemy.transform.position)<=2.2f&&Vector3.Distance(Player.transform.position,thisenemy.transform.position)>16f&&Vector3.Distance(Player2.transform.position,thisenemy.transform.position)>16f){
			anim.SetBool("walk",false);
			transform.LookAt(new Vector3(chan.transform.position.x,transform.position.y,chan.transform.position.z));
			attackmode=0;
		}
	}
	public void attackopenCol(){
		Bull_attack12.Play(); NM.enabled=false;
		Weapon.GetComponent<SphereCollider>().enabled=true;attackmode=6;
	}
	public void attackcloseCol(){
		Weapon.GetComponent<SphereCollider>().enabled=false;attackmode=0; NM.enabled=true; anim.ResetTrigger("attack1");
		anim.ResetTrigger("attack2");
		anim.ResetTrigger("attack3");
		anim.ResetTrigger("attack4");
	}	
	public void dieStart(){
		exp.currentExp+=2200;
		if(save2.point5finish<1){
			save2.currentMoney=save2.currentMoney+Bull_EnemyHealth.dropmoney;
		}
		else{
			save2.currentMoney=save2.currentMoney+Bull_EnemyHealth.dropmoney+Bull_EnemyHealth.dropmoney;
		}
		Bulldieing.Play();save2.findgirlMfinish++;chan.GetComponent<Animator>().SetBool("talk",true);
		Player.transform.position=new Vector3(355.554626f,29.8205147f,251.070541f);
		if(save2.isjoined==true){
			Player2.transform.position=new Vector3(357.112793f,29.8205147f,250.653732f);
			save2.isinshop=false;
		}
		missionsuccesscanvas.SetActive(true);
		All_colliderwall.SetActive(true);
		finishmissioncanvas.SetActive(true);
	}
	public void dieEnd(){
		Destroy(this.gameObject,0.2f);
	}
	public void gethit(){
		attackmode=6; NM.enabled=false;
		attackcloseCol();
		anim.ResetTrigger("attack1");
		anim.ResetTrigger("attack2");
		anim.ResetTrigger("attack3");
		anim.ResetTrigger("attack4");
	}
	public void gethitEnd(){
		attackmode=0; NM.enabled=true; Bull_EnemyHealth.hitbyPlayercount=0;
	}
}