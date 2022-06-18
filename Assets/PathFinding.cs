using UnityEngine;using UnityEngine.AI;public class PathFinding:MonoBehaviour{
	NavMeshAgent NM;
	Transform Player;
	Animator anim;
	AudioSource sound;
	private bool trig;
	public GameObject message1;
	void Start(){
		NM=GetComponent<NavMeshAgent>();
		anim=GetComponent<Animator>();
		sound=GetComponent<AudioSource>();}
	void Update(){
		Player=GameObject.FindWithTag("Player").transform;
		if(trig){NM.SetDestination(Player.position);}}
	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag=="Player"){
			anim.SetBool("IsLook",false);
			NM.enabled=true;
			trig=true;
			sound.Play();
			this.gameObject.transform.LookAt(new Vector3(Player.transform.position.x,transform.position.y,Player.transform.position.z));
		}
	}
	void OnTriggerStay(Collider other2){
		if(other2.gameObject.tag=="Player"){
			anim.SetBool("IsLook",false);
			NM.enabled=true;
			trig=true;
			this.gameObject.transform.LookAt(new Vector3(Player.transform.position.x,transform.position.y,Player.transform.position.z));message1.SetActive(false);			
		}
	}
	void OnTriggerExit(Collider other3){
		if(other3.gameObject.tag=="Player"){
			anim.SetBool("IsLook",true);
			NM.enabled=false;
			trig=false;
			sound.Stop();}}}