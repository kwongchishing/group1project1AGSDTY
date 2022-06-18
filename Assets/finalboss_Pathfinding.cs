using UnityEngine;using UnityEngine.AI;public class finalboss_Pathfinding:MonoBehaviour{
	NavMeshAgent NM;
	public Transform Player;
	Animator anim;public WAXE_exp exp;public save2 save2;public finalboss_EnemyHealth finalboss_EnemyHealth;
	public int attackmode=0;
	public GameObject HealthBar,kinggivepotioncanvas,kinggivepotion,finishgametalk1,player,Weapon,finalbosselectric,explosestormcircle,fireattack4FX,stonedrop5,waterfall6,lighting,dragonforfight;
	public AudioSource finalboss_attack1,finalboss_attack2,finalboss_attack3,finalboss_attack4,finalboss_attack5,finalboss_attack6,die,finalbossstorm,finalbossfire,finalbossStonedrop,waterfall;
	void Start(){
		NM=GetComponent<NavMeshAgent>();
		anim=GetComponent<Animator>();NM.enabled=true;
	}
	void Update(){
		if(finalboss_EnemyHealth.currentHealth>0){
			transform.LookAt(new Vector3(Player.transform.position.x,transform.position.y,Player.transform.position.z));}
		if(Vector3.Distance(Player.transform.position,transform.position)>=2.8f&&finalboss_EnemyHealth.currentHealth>0){
			anim.SetBool("walk",true);
			NM.SetDestination(Player.position);
			NM.enabled=true;
		}
		if(Vector3.Distance(Player.transform.position,transform.position)<2.8f&&Vector3.Distance(Player.transform.position,transform.position)>=1.9f&&finalboss_EnemyHealth.currentHealth>0){			
			if(attackmode==0){
				attackmode=Random.Range(2,7);
				if(attackmode==2) anim.SetTrigger("attack2");
				else if(attackmode==3) anim.SetTrigger("attack3");
				else if(attackmode==4) anim.SetTrigger("attack4");
				else if(attackmode==5) anim.SetTrigger("attack5");
				else anim.SetTrigger("attack6");
			}
		}
		if(Vector3.Distance(Player.transform.position,transform.position)<1.9f&&finalboss_EnemyHealth.currentHealth>0){
			if(attackmode==0){
				attackmode=Random.Range(1,7);
				if(attackmode==1){anim.SetTrigger("attack1");}
				else if(attackmode==2){anim.SetTrigger("attack2");}
				else if(attackmode==3){anim.SetTrigger("attack3");}
				else if(attackmode==4){anim.SetTrigger("attack4");}
				else if(attackmode==5){anim.SetTrigger("attack5");}
				else if(attackmode==6){anim.SetTrigger("attack6");}
			}
		}
	}
	public void guardattackopenCol(){
		NM.enabled=false;
		finalboss_attack1.Play();
		Weapon.GetComponent<CapsuleCollider>().enabled=true;attackmode=6;
	}
	public void guardattackcloseCol(){
		Weapon.GetComponent<CapsuleCollider>().enabled=false;
		anim.ResetTrigger("attack1");
		anim.ResetTrigger("attack2");
		anim.ResetTrigger("attack3");
		anim.ResetTrigger("attack4");
		anim.ResetTrigger("attack5");
		anim.ResetTrigger("attack6");attackmode=0;
	}
	public void magicattack2openCol(){
		Weapon.GetComponent<CapsuleCollider>().enabled=false;NM.enabled=false;
		finalboss_attack2.Play();
		finalbosselectric.SetActive(true);attackmode=6;lighting.SetActive(true);
	}
	public void magicattack2closeCol(){
		NM.enabled=true;
		finalbosselectric.SetActive(false);lighting.SetActive(false);
		anim.ResetTrigger("attack1");
		anim.ResetTrigger("attack2");
		anim.ResetTrigger("attack3");
		anim.ResetTrigger("attack4");
		anim.ResetTrigger("attack5");
		anim.ResetTrigger("attack6");
		attackmode=0;
	}
	public void magicattack3openCol(){
		Weapon.GetComponent<CapsuleCollider>().enabled=false;NM.enabled=false;
		finalboss_attack3.Play();
		explosestormcircle.SetActive(true);attackmode=6;finalbossstorm.Play();
	}
	public void magicattack3closeCol(){
		NM.enabled=true;
		explosestormcircle.SetActive(false);
		anim.ResetTrigger("attack1");
		anim.ResetTrigger("attack2");
		anim.ResetTrigger("attack3");
		anim.ResetTrigger("attack4");
		anim.ResetTrigger("attack5");
		anim.ResetTrigger("attack6");
		attackmode=0;
	}
	public void magicattack4openCol(){
		Weapon.GetComponent<CapsuleCollider>().enabled=false;NM.enabled=false;
		finalboss_attack4.Play();
		fireattack4FX.SetActive(true);
		attackmode=6;finalbossfire.Play();
	}
	public void magicattack4closeCol(){
		NM.enabled=true;
		fireattack4FX.SetActive(false);
		anim.ResetTrigger("attack1");
		anim.ResetTrigger("attack2");
		anim.ResetTrigger("attack3");
		anim.ResetTrigger("attack4");
		anim.ResetTrigger("attack5");
		anim.ResetTrigger("attack6");
		attackmode=0;
	}
	public void magicattack5openCol(){
		Weapon.GetComponent<CapsuleCollider>().enabled=false;NM.enabled=false;
		finalboss_attack5.Play();
		stonedrop5.SetActive(true);attackmode=6;finalbossStonedrop.Play();
	}
	public void magicattack5closeCol(){
		NM.enabled=true;
		stonedrop5.SetActive(false);
		anim.ResetTrigger("attack1");
		anim.ResetTrigger("attack2");
		anim.ResetTrigger("attack3");
		anim.ResetTrigger("attack4");
		anim.ResetTrigger("attack5");
		anim.ResetTrigger("attack6");
		attackmode=0;
	}
	public void magicattack6openCol(){
		Weapon.GetComponent<CapsuleCollider>().enabled=false;NM.enabled=false;
		finalboss_attack6.Play();
		waterfall6.SetActive(true);
		attackmode=6;waterfall.Play();
	}
	public void magicattack6closeCol(){		
		waterfall6.SetActive(false);NM.enabled=true;
		anim.ResetTrigger("attack1");
		anim.ResetTrigger("attack2");
		anim.ResetTrigger("attack3");
		anim.ResetTrigger("attack4");
		anim.ResetTrigger("attack5");
		anim.ResetTrigger("attack6");
		attackmode=0;
	}
	public void dieStart(){
		player.GetComponent<Animator>().SetBool("stop",true);die.Play();attackmode=6;anim.ResetTrigger("attack1");
		anim.ResetTrigger("attack2");
		anim.ResetTrigger("attack3");
		anim.ResetTrigger("attack4");
		anim.ResetTrigger("attack5");
		anim.ResetTrigger("attack6");dragonforfight.GetComponent<Animator>().SetTrigger("die");dragonforfight.GetComponent<NavMeshAgent>().enabled=false;
		exp.currentExp+=600;Weapon.GetComponent<CapsuleCollider>().enabled=false;
		save2.currentMoney=save2.currentMoney+finalboss_EnemyHealth.dropmoney;
		finalbosselectric.SetActive(false);
		explosestormcircle.SetActive(false);fireattack4FX.SetActive(false);stonedrop5.SetActive(false);waterfall6.SetActive(false);lighting.SetActive(false);
		transform.LookAt(new Vector3(transform.position.x,transform.position.y,transform.position.z));Destroy(HealthBar);
	}
	public void dieEnd(){
		player.gameObject.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl>().enabled=false; 		
		player.GetComponent<Rigidbody>().constraints=RigidbodyConstraints.FreezePositionX|RigidbodyConstraints.FreezePositionZ|RigidbodyConstraints.FreezeRotationX|RigidbodyConstraints.FreezeRotationY|RigidbodyConstraints.FreezeRotationZ;
		player.SetActive(false);
		player.SetActive(true);
		player.transform.position=new Vector3(2346.66992f,1206.19861f,-2993.58008f);
		player.transform.rotation=Quaternion.Euler(0,228.649063f,0);
		finishgametalk1.SetActive(true);if(kinggivepotion!=null) Destroy(kinggivepotion);
		if(kinggivepotioncanvas!=null) Destroy(kinggivepotioncanvas);
	}
	public void gethit(){
		attackmode=6;NM.enabled=false;
		finalbosselectric.SetActive(false);explosestormcircle.SetActive(false);fireattack4FX.SetActive(false);stonedrop5.SetActive(false);waterfall6.SetActive(false); Weapon.GetComponent<CapsuleCollider>().enabled=false;
	}
	public void gethitEnd(){
		anim.ResetTrigger("attack1");
		anim.ResetTrigger("attack2");
		anim.ResetTrigger("attack3");
		anim.ResetTrigger("attack4");
		anim.ResetTrigger("attack5");
		anim.ResetTrigger("attack6");
		attackmode=0;NM.enabled=true;
	}
	public void walk(){
		attackmode=0;NM.enabled=true; finalbosselectric.SetActive(false); explosestormcircle.SetActive(false); fireattack4FX.SetActive(false); stonedrop5.SetActive(false); waterfall6.SetActive(false); Weapon.GetComponent<CapsuleCollider>().enabled=false;
	}
	public void nmfalse(){
		NM.enabled=false;
	}
	public void nmtrue(){
		NM.enabled=true;
	}
}