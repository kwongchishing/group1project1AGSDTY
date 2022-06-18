using UnityEngine;using UnityEngine.AI;public class dragon_Pathfinding:MonoBehaviour{
    NavMeshAgent NM;
    public finalboss_EnemyHealth finalboss_EnemyHealth;
    public Transform pointhub1,pointhub2,pointhub3,pointhub4,pointhub5;
    void Start(){
        NM=GetComponent<NavMeshAgent>();
    }
    void Update(){
        if(finalboss_EnemyHealth.dragonchangepositioncount==0){
            NM.SetDestination(pointhub1.position);
        }
        if(finalboss_EnemyHealth.dragonchangepositioncount>=10&&finalboss_EnemyHealth.dragonchangepositioncount<=20){
            NM.SetDestination(pointhub2.position); 
        }
        if(finalboss_EnemyHealth.dragonchangepositioncount>=21&&finalboss_EnemyHealth.dragonchangepositioncount<=30){
            NM.SetDestination(pointhub3.position);
        }
        if(finalboss_EnemyHealth.dragonchangepositioncount>=31&&finalboss_EnemyHealth.dragonchangepositioncount<=40){
            NM.SetDestination(pointhub4.position);
        }
        if(finalboss_EnemyHealth.dragonchangepositioncount>=41&&finalboss_EnemyHealth.dragonchangepositioncount<=50){
            NM.SetDestination(pointhub5.position);
        }
        if(finalboss_EnemyHealth.dragonchangepositioncount>=51&&finalboss_EnemyHealth.dragonchangepositioncount<=60){
            NM.SetDestination(pointhub2.position);
        }
        if(finalboss_EnemyHealth.dragonchangepositioncount>60){
            finalboss_EnemyHealth.dragonchangepositioncount=0;
        }
    }
}