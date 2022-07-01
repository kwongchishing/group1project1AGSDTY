using UnityEngine;using UnityEngine.AI;public class towerpathfinding:MonoBehaviour{
	NavMeshAgent NM;
	Animator anim;
	public killtowerattacker killtowerattacker;
	public Transform Tower;
	public AudioSource foxdie;
	public WAXE_exp exp;
	public foxhealth foxhealth;
	public save2 save2;
	void Start(){
		NM=GetComponent<NavMeshAgent>();
		anim=GetComponent<Animator>();
	}
	void Update(){
		NM.SetDestination(Tower.position);
	this.gameObject.transform.LookAt(new Vector3(Tower.transform.position.x,transform.position.y,Tower.transform.position.z));
		if(Vector3.Distance(Tower.transform.position,transform.position)<2.9f){
			anim.SetBool("attack",true);
			NM.enabled=false;
		}		
	}	
	public void die(){
		killtowerattacker.killcount++;
		exp.currentExp+=90;
		if(save2.point5finish<1){
			save2.currentMoney=save2.currentMoney+foxhealth.dropmoney;
		}
		else{
			save2.currentMoney=save2.currentMoney+foxhealth.dropmoney+foxhealth.dropmoney;
		}
		foxdie.Play();GetComponent<BoxCollider>().enabled=false;
		Destroy(this.gameObject,3f);
	}
}