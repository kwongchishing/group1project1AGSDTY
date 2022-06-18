using UnityEngine;using UnityEngine.AI;public class bull_Enemypathfinding:MonoBehaviour{
	NavMeshAgent NM;
	public Transform Player2,Player,thisenemy;
	Animator anim; public WAXE_exp exp;public save2 save2;public Bull_EnemyHealth Bull_EnemyHealth;
	public int attackmode=0;
	public GameObject WeaponL,WeaponR,HealthObject, WeaponLheavy, WeaponRheavy;
	public AudioSource foundPlayer,Bull_attack12,Bull_attack3,Bulldieing;
	bool trig;
	void Start(){
		NM=GetComponent<NavMeshAgent>();
		anim=GetComponent<Animator>();}
	void Update(){
		if(Vector3.Distance(Player.transform.position,thisenemy.transform.position)<=5f){
			if(Bull_EnemyHealth.currentHealth>0){transform.LookAt(new Vector3(Player.transform.position.x,transform.position.y,Player.transform.position.z));}
			anim.SetBool("walk",true);
			NM.SetDestination(Player.position);
			attackmode=0;
		}
		if (Vector3.Distance(Player2.transform.position, thisenemy.transform.position) <=5f)
		{
			if (Bull_EnemyHealth.currentHealth > 0) { transform.LookAt(new Vector3(Player2.transform.position.x, transform.position.y, Player2.transform.position.z)); }
			anim.SetBool("walk", true);
			NM.SetDestination(Player2.position);
			attackmode = 0;
		}
		if (Vector3.Distance(Player.transform.position, thisenemy.transform.position) <=5f&& Vector3.Distance(Player2.transform.position, thisenemy.transform.position) <=5f)
		{
			if (Vector3.Distance(Player.transform.position, transform.position) < Vector3.Distance(Player2.transform.position, transform.position))
			{
				if (Bull_EnemyHealth.currentHealth > 0) { transform.LookAt(new Vector3(Player.transform.position.x, transform.position.y, Player.transform.position.z)); }
				anim.SetBool("walk", true);
				NM.SetDestination(Player.position);
				attackmode = 0;
			}
		}
		if (Vector3.Distance(Player.transform.position, thisenemy.transform.position) <= 5f && Vector3.Distance(Player2.transform.position, thisenemy.transform.position) <=5f)
		{
			if (Vector3.Distance(Player.transform.position, transform.position) > Vector3.Distance(Player2.transform.position, transform.position))
			{
				if (Bull_EnemyHealth.currentHealth > 0) { transform.LookAt(new Vector3(Player2.transform.position.x, transform.position.y, Player2.transform.position.z)); }
				anim.SetBool("walk", true);
				NM.SetDestination(Player2.position);
				attackmode = 0;
			}
		}
		if (Vector3.Distance(Player.transform.position,transform.position)<2.5f){
			if(attackmode==0){
				attackmode=Random.Range(1,5);
				if(attackmode==1){anim.SetTrigger("attack1");}
				else if(attackmode==2){anim.SetTrigger("attack2");}
				else if(attackmode==3){anim.SetTrigger("attack3");}
				else{anim.SetTrigger("attack4");}
			}
		}
		if (Vector3.Distance(Player2.transform.position, transform.position) < 2.5f)
		{
			if (attackmode == 0)
			{
				attackmode = Random.Range(1, 5);
				if (attackmode == 1) { anim.SetTrigger("attack1");}
				else if (attackmode == 2) { anim.SetTrigger("attack2");}
				else if (attackmode == 3) { anim.SetTrigger("attack3");}
				else { anim.SetTrigger("attack4");}
			}
		}
		if (Vector3.Distance(Player.transform.position,thisenemy.transform.position)>5f&&!this.anim.GetCurrentAnimatorStateInfo(0).IsName("dizzy")&& Vector3.Distance(Player2.transform.position, thisenemy.transform.position)>5f)
		{
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
		if (Vector3.Distance(Player.transform.position,thisenemy.transform.position)>5f&&this.anim.GetCurrentAnimatorStateInfo(0).IsName("dizzy")&& Vector3.Distance(Player2.transform.position, thisenemy.transform.position) >5f)
		{
			anim.SetBool("walk", true);
			attackmode=6;
			if(Bull_EnemyHealth.currentHealth>0){
				transform.LookAt(new Vector3(transform.position.x,transform.position.y,transform.position.z));
			}
			NM.SetDestination(thisenemy.position);
			anim.ResetTrigger("attack1");
			anim.ResetTrigger("attack2");
			anim.ResetTrigger("attack3");
			anim.ResetTrigger("attack4");
		}		
		if (Vector3.Distance(transform.position,thisenemy.transform.position)<=2.2f&&Vector3.Distance(Player.transform.position,thisenemy.transform.position)>5f&& Vector3.Distance(Player2.transform.position, thisenemy.transform.position) > 5f)
		{
			anim.SetBool("walk",false);
			attackmode=0;
		}		
		if (Vector3.Distance(Player.transform.position,transform.position)<5f&&Vector3.Distance(Player.transform.position,transform.position)>4.5f){
			foundPlayer.Play();
		}
		else if (Vector3.Distance(Player2.transform.position, transform.position) < 5f && Vector3.Distance(Player2.transform.position, transform.position) > 4.5f)
		{
			foundPlayer.Play();
		}
	}	
	public void attackopenCol(){
		Bull_attack12.Play(); NM.enabled=false;
		WeaponL.GetComponent<SphereCollider>().enabled=true;
		WeaponR.GetComponent<SphereCollider>().enabled=true;attackmode=6;
	}
	public void attackcloseCol(){
		WeaponL.GetComponent<SphereCollider>().enabled=false;
		WeaponR.GetComponent<SphereCollider>().enabled=false;attackmode=0;NM.enabled=true; anim.ResetTrigger("attack1");
		anim.ResetTrigger("attack2");
		anim.ResetTrigger("attack3");
		anim.ResetTrigger("attack4");
	}
	public void attack3soundplay()
    {
		Bull_attack3.Play();
	}
	public void heavyattackopenCol(){
		NM.enabled=false;
		WeaponLheavy.GetComponent<SphereCollider>().enabled=true;
		WeaponRheavy.GetComponent<SphereCollider>().enabled=true; attackmode=6;
	}
	public void heavyattackcloseCol(){
		WeaponLheavy.GetComponent<SphereCollider>().enabled=false;
		WeaponRheavy.GetComponent<SphereCollider>().enabled=false; attackmode=0; NM.enabled =true; anim.ResetTrigger("attack1");
		anim.ResetTrigger("attack2");
		anim.ResetTrigger("attack3");
		anim.ResetTrigger("attack4");
	}
	public void dizzyNomoveStart(){
		NM.enabled=false; attackmode=6;
	}
	public void dizzyNomoveEnd(){
		NM.enabled=true;attackmode=0;
	}
	public void dieStart(){
		exp.currentExp+=300;
		if(save2.point5finish<1){
			save2.currentMoney=save2.currentMoney+Bull_EnemyHealth.dropmoney;
		}
        else{
			save2.currentMoney=save2.currentMoney+Bull_EnemyHealth.dropmoney+Bull_EnemyHealth.dropmoney;
		}
		save2.goodbadcount-=5;
		Bulldieing.Play();
	}
	public void dieEnd(){
		Destroy(this.gameObject,0.2f);
    }
	public void gethit(){
		attackmode=6; NM.enabled=false;
		heavyattackcloseCol();
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