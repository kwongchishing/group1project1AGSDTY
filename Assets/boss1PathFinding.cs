using UnityEngine;using UnityEngine.AI;public class boss1PathFinding:MonoBehaviour{
	NavMeshAgent NM;
	public Transform Player;
	Animator anim;
	public float pushcount;
	public GameObject pushhand,boss1rotateSound,pushSoundObject,boss1rotatebody;
	public boss1bipLookatPlayer boss1bipLookatPlayer;
	void Start(){NM=GetComponent<NavMeshAgent>();
		anim=GetComponent<Animator>();
	}	
	void Update(){
		NM.SetDestination(Player.position);
		if(boss1bipLookatPlayer.pushcount>5){
			anim.SetBool("push",false);
			boss1rotateSound.SetActive(true);
			anim.SetBool("rotate",true);
			boss1rotatebody.SetActive(true);
			pushSoundObject.SetActive(false);}}
	public void pushStart(){pushhand.SetActive(true);}
	public void pushEnd(){pushhand.SetActive(false);}
	public void rotateATKend(){		
		boss1rotateSound.SetActive(false);
		boss1rotatebody.SetActive(false);
		pushSoundObject.SetActive(true);anim.SetBool("rotate",false);boss1bipLookatPlayer.pushcount=0;}}