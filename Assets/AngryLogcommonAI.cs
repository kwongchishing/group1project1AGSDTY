using UnityEngine;using UnityEngine.AI;public class AngryLogcommonAI:MonoBehaviour{
	NavMeshAgent NM;
	Transform Player;
	Animator anim;
	AudioSource sound;
	private bool trig;
	void Start(){
		NM=GetComponent<NavMeshAgent>();
		anim=GetComponent<Animator>();
		sound=GetComponent<AudioSource>();
	}
	void Update(){
		Player=GameObject.FindWithTag("Player").transform;
		if(trig){
			NM.SetDestination(Player.position);}
	}
	void OnTriggerEnter(Collider other){
		if(other.gameObject.tag=="Player"){
			anim.SetBool("IsLook",false);
			NM.enabled=true;
			trig=true;
			sound.Play();
		}
	}
	void OnTriggerStay(Collider other2){
		if(other2.gameObject.tag=="Player"){
			anim.SetBool("IsLook",false);
			NM.enabled=true;
			trig=true;
		}
	}
	void OnTriggerExit(Collider other3){
		if(other3.gameObject.tag=="Player"){
			anim.SetBool("IsLook",true);
			NM.enabled=false;
			trig=false;
			sound.Stop();
		}
	}
}