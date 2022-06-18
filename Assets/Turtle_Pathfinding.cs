using UnityEngine;using UnityEngine.AI;public class Turtle_Pathfinding:MonoBehaviour{
	NavMeshAgent NM;public Transform Player;
	Animator anim; public WAXE_exp exp; public save2 save2; public Turtle_EnemyHealth Turtle_EnemyHealth;
	public int attackmode=0;
	public GameObject Weapon;
	public Transform thisenemy;
	public AudioSource foundPlayer,turtle_attack1,die;
	void Start(){
		NM=GetComponent<NavMeshAgent>();
		anim=GetComponent<Animator>();}
	void Update(){
		if(Player==null) Player=GameObject.FindWithTag("Player").transform;
		if(Vector3.Distance(Player.transform.position, thisenemy.transform.position)<=11f){
			if(Turtle_EnemyHealth.currentHealth>0){transform.LookAt(new Vector3(Player.transform.position.x,transform.position.y,Player.transform.position.z));}
			anim.SetBool("walk",true);
			NM.SetDestination(Player.position);
		}
		if(Vector3.Distance(Player.transform.position,transform.position)<2.2f&&Turtle_EnemyHealth.currentHealth>0){
			if(attackmode==0){
				attackmode=Random.Range(1,5);
				if(attackmode==1){anim.SetTrigger("attack1");}
				else if(attackmode==2){anim.SetTrigger("attack2");}
				else if(attackmode==3){anim.SetTrigger("attack3");}
				else{anim.SetTrigger("attack4");}
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
	public void turtleattackopenCol(){
		NM.enabled=false;turtle_attack1.Play();
		Weapon.GetComponent<BoxCollider>().enabled=true;attackmode=6;
	}
	public void turtleattackcloseCol(){
		Weapon.GetComponent<BoxCollider>().enabled=false;attackmode=0;NM.enabled=true;
	}	
	public void dieStart(){
		anim.ResetTrigger("attack1");
		anim.ResetTrigger("attack2");
		anim.ResetTrigger("attack3");
		anim.ResetTrigger("attack4");Weapon.GetComponent<BoxCollider>().enabled=false;NM.enabled=false;die.Play();attackmode=6;
		exp.currentExp+=100;
		save2.currentMoney=save2.currentMoney+Turtle_EnemyHealth.dropmoney;
		save2.goodbadcount--;
	}
	public void dieEnd(){
		Destroy(this.gameObject,0.2f);
	}
	public void gethit(){
		Weapon.GetComponent<BoxCollider>().enabled=false;attackmode=6;NM.enabled=false;}
	public void gethitEnd(){
		Weapon.GetComponent<BoxCollider>().enabled=false;attackmode=0;NM.enabled=true;}
	public void walk(){
		Weapon.GetComponent<BoxCollider>().enabled=false;attackmode=0;NM.enabled=true;}
}