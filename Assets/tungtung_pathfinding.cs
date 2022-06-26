using UnityEngine.AI;using UnityEngine;public class tungtung_pathfinding:MonoBehaviour{
    public Transform tower,bull3,bull2,bull1,Player1,fox19,fox18,fox17,fox16,fox15,fox14,fox13,fox12,fox11,fox10,fox9,fox8,fox7,fox5,fox,fox2,fox6,fox3,fox4,bull_king;
    NavMeshAgent NM;
    Animator anim;
    public save2 save2;
    public AudioSource attacksound;
    public GameObject bull3healthbar,bull2healthbar,bull1healthbar,fox19healthbar,fox18healthbar,fox17healthbar,fox16healthbar,fox15healthbar,fox14healthbar,fox13healthbar,fox12healthbar,fox11healthbar,fox10healthbar,fox9healthbar,fox8healthbar,foxhealthbar,fox7healthbar,fox6healthbar,fox5healthbar,fox4healthbar,fox2healthbar,fox3healthbar,bullhealthbar,Katana,bed;
    void Start(){
        NM=GetComponent<NavMeshAgent>();
        anim=GetComponent<Animator>();
    }
    public void attack1Start(){ attacksound.Play(); Katana.SetActive(true);Katana.GetComponent<BoxCollider>().enabled=true;}
    public void attack1End(){Katana.SetActive(false);Katana.GetComponent<BoxCollider>().enabled=false;anim.ResetTrigger("attack1");}
    void Update(){
        if(Vector3.Distance(Player1.transform.position,transform.position)>4f&&Vector3.Distance(Player1.transform.position,transform.position)<=36f){
            NM.enabled=true;NM.SetDestination(Player1.position);anim.SetBool("walk",true); anim.SetBool("sleep", false); anim.ResetTrigger("attack1");
        }
        else if(Vector3.Distance(Player1.transform.position,transform.position)<4f&&Vector3.Distance(bed.transform.position,transform.position)>30f){
            anim.ResetTrigger("attack1"); anim.SetBool("sleep",false); anim.SetBool("walk",false); transform.LookAt(new Vector3(Player1.transform.position.x,transform.position.y,Player1.transform.position.z));
        }
        if(Vector3.Distance(Player1.transform.position,transform.position)>36f){
            transform.position=Player1.transform.position+new Vector3(0,0,-2f);
            NM.enabled=false;NM.enabled=true; anim.SetBool("sleep",false); anim.ResetTrigger("attack1");
        }
        if(save2.isinshop==true&&Vector3.Distance(bed.transform.position,transform.position)>30f){
            anim.ResetTrigger("attack1"); anim.SetBool("sleep",false); anim.SetBool("walk",false);transform.LookAt(new Vector3(Player1.transform.position.x,transform.position.y,Player1.transform.position.z));
        }
        if(Vector3.Distance(bed.transform.position,transform.position)<10f){
            anim.ResetTrigger("attack1"); anim.SetBool("walk",false);
            anim.SetBool("sleep",true);
            transform.position=new Vector3(977.08197f,-116.570999f,-118.732002f);
        }
        else{anim.SetBool("sleep",false);}
        //help attack
        if(bullhealthbar!=null&&Vector3.Distance(bull_king.transform.position,Player1.transform.position)<4&&Vector3.Distance(bull_king.transform.position,transform.position)>2.3){
            NM.enabled=true; NM.SetDestination(bull_king.position); anim.SetBool("walk",true);
            transform.LookAt(new Vector3(bull_king.transform.position.x,transform.position.y,bull_king.transform.position.z));
        }
        if(bullhealthbar!=null&&Vector3.Distance(bull_king.transform.position,Player1.transform.position)<4&&Vector3.Distance(bull_king.transform.position,transform.position)<=2.3){
            NM.enabled=true; NM.SetDestination(bull_king.position);anim.SetBool("walk",false);
            anim.SetTrigger("attack1");
            transform.LookAt(new Vector3(bull_king.transform.position.x,transform.position.y,bull_king.transform.position.z));
        }
        if(foxhealthbar!=null&&Vector3.Distance(fox.transform.position,Player1.transform.position)<4&&Vector3.Distance(fox.transform.position,transform.position)>2.3&&Vector3.Distance(tower.transform.position,transform.position)<6){
            NM.enabled=true;NM.SetDestination(fox.position);anim.SetBool("walk",true);
            transform.LookAt(new Vector3(fox.transform.position.x,transform.position.y,fox.transform.position.z));
        }
        if(foxhealthbar!=null&&Vector3.Distance(fox.transform.position,Player1.transform.position)<4&&Vector3.Distance(fox.transform.position,transform.position)<=2.3&&Vector3.Distance(tower.transform.position,transform.position)<6){
            NM.enabled=true;NM.SetDestination(fox.position);anim.SetBool("walk",false);
            anim.SetTrigger("attack1");
            transform.LookAt(new Vector3(fox.transform.position.x,transform.position.y,fox.transform.position.z));
        }
        if(fox2healthbar!=null&&Vector3.Distance(fox2.transform.position,Player1.transform.position)<4&&Vector3.Distance(fox2.transform.position,transform.position)>2.3&&Vector3.Distance(tower.transform.position,transform.position)<6){
            NM.enabled=true;NM.SetDestination(fox2.position);anim.SetBool("walk",true);
            transform.LookAt(new Vector3(fox2.transform.position.x,transform.position.y,fox2.transform.position.z));
        }
        if(fox2healthbar!=null&&Vector3.Distance(fox2.transform.position,Player1.transform.position)<4&&Vector3.Distance(fox2.transform.position,transform.position)<=2.3&&Vector3.Distance(tower.transform.position,transform.position)<6){
            NM.enabled=true;NM.SetDestination(fox2.position);anim.SetBool("walk",false);
            anim.SetTrigger("attack1");
            transform.LookAt(new Vector3(fox2.transform.position.x,transform.position.y,fox2.transform.position.z));
        }
        if(fox3healthbar!=null&&Vector3.Distance(fox3.transform.position,Player1.transform.position)<4&&Vector3.Distance(fox3.transform.position,transform.position)>2.3&&Vector3.Distance(tower.transform.position,transform.position)<6){
            NM.enabled=true;NM.SetDestination(fox3.position);anim.SetBool("walk",true);
            transform.LookAt(new Vector3(fox3.transform.position.x,transform.position.y,fox3.transform.position.z));
        }
        if(fox3healthbar!=null&&Vector3.Distance(fox3.transform.position,Player1.transform.position)<4&&Vector3.Distance(fox3.transform.position,transform.position)<= 2.3&&Vector3.Distance(tower.transform.position,transform.position)<6){
            NM.enabled=true;NM.SetDestination(fox3.position);anim.SetBool("walk",false);
            anim.SetTrigger("attack1");
            transform.LookAt(new Vector3(fox3.transform.position.x,transform.position.y,fox3.transform.position.z));
        }
        if(fox4healthbar!=null&&Vector3.Distance(fox4.transform.position,Player1.transform.position)<4&&Vector3.Distance(fox4.transform.position,transform.position)>2.3&&Vector3.Distance(tower.transform.position,transform.position)<6){
            NM.enabled=true;NM.SetDestination(fox4.position);anim.SetBool("walk",true);
            transform.LookAt(new Vector3(fox4.transform.position.x,transform.position.y,fox4.transform.position.z));
        }
        if(fox4healthbar!=null&&Vector3.Distance(fox4.transform.position,Player1.transform.position)<4&&Vector3.Distance(fox4.transform.position,transform.position)<= 2.3&&Vector3.Distance(tower.transform.position,transform.position)<6){
            NM.enabled=true;NM.SetDestination(fox4.position);anim.SetBool("walk",false);
            anim.SetTrigger("attack1");
            transform.LookAt(new Vector3(fox4.transform.position.x,transform.position.y,fox4.transform.position.z));
        }
        if(fox5healthbar!=null&&Vector3.Distance(fox5.transform.position,Player1.transform.position)<4&&Vector3.Distance(fox5.transform.position,transform.position)>2.3&&Vector3.Distance(tower.transform.position,transform.position)<6){
            NM.enabled=true;NM.SetDestination(fox5.position);anim.SetBool("walk",true);
            transform.LookAt(new Vector3(fox5.transform.position.x,transform.position.y,fox5.transform.position.z));
        }
        if(fox5healthbar!=null&&Vector3.Distance(fox5.transform.position,Player1.transform.position)<4&&Vector3.Distance(fox5.transform.position,transform.position)<=2.3&&Vector3.Distance(tower.transform.position,transform.position)<6){
            NM.enabled=true;NM.SetDestination(fox5.position);anim.SetBool("walk",false);
            anim.SetTrigger("attack1");
            transform.LookAt(new Vector3(fox5.transform.position.x,transform.position.y,fox5.transform.position.z));
        }
        if(fox6healthbar!=null&&Vector3.Distance(fox6.transform.position,Player1.transform.position)<4&&Vector3.Distance(fox6.transform.position,transform.position)>2.3&&Vector3.Distance(tower.transform.position,transform.position)<6){
            NM.enabled=true;NM.SetDestination(fox6.position);anim.SetBool("walk",true);
            transform.LookAt(new Vector3(fox6.transform.position.x,transform.position.y,fox6.transform.position.z));
        }
        if(fox6healthbar!=null&&Vector3.Distance(fox6.transform.position,Player1.transform.position)<4&&Vector3.Distance(fox6.transform.position,transform.position)<=2.3&&Vector3.Distance(tower.transform.position,transform.position)<6){
            NM.enabled=true;NM.SetDestination(fox6.position);anim.SetBool("walk",false);
            anim.SetTrigger("attack1");
            transform.LookAt(new Vector3(fox6.transform.position.x,transform.position.y,fox6.transform.position.z));
        }
        if(fox7healthbar!=null&&Vector3.Distance(fox7.transform.position,Player1.transform.position)<4&&Vector3.Distance(fox7.transform.position,transform.position)>2.3&&Vector3.Distance(tower.transform.position,transform.position)<6){
            NM.enabled=true;NM.SetDestination(fox7.position);anim.SetBool("walk",true);
            transform.LookAt(new Vector3(fox7.transform.position.x,transform.position.y,fox7.transform.position.z));
        }
        if(fox7healthbar!=null&&Vector3.Distance(fox7.transform.position,Player1.transform.position)<4&&Vector3.Distance(fox7.transform.position,transform.position)<=2.3&&Vector3.Distance(tower.transform.position,transform.position)<6){
            NM.enabled=true;NM.SetDestination(fox7.position);anim.SetBool("walk",false);
            anim.SetTrigger("attack1");
            transform.LookAt(new Vector3(fox7.transform.position.x,transform.position.y,fox7.transform.position.z));
        }
        if(fox8healthbar!=null&&Vector3.Distance(fox8.transform.position,Player1.transform.position)<4&&Vector3.Distance(fox8.transform.position,transform.position)>2.3&&Vector3.Distance(tower.transform.position,transform.position)<6){
            NM.enabled=true;NM.SetDestination(fox8.position);anim.SetBool("walk",true);
            transform.LookAt(new Vector3(fox8.transform.position.x,transform.position.y,fox8.transform.position.z));
        }
        if(fox8healthbar!=null&&Vector3.Distance(fox8.transform.position,Player1.transform.position)<4&&Vector3.Distance(fox8.transform.position,transform.position)<=2.3&&Vector3.Distance(tower.transform.position,transform.position)<6){
            NM.enabled=true;NM.SetDestination(fox8.position);anim.SetBool("walk",false);
            anim.SetTrigger("attack1");
            transform.LookAt(new Vector3(fox8.transform.position.x,transform.position.y,fox8.transform.position.z));
        }
        if(fox9healthbar!=null&&Vector3.Distance(fox9.transform.position,Player1.transform.position)<4&&Vector3.Distance(fox9.transform.position,transform.position)>2.3&&Vector3.Distance(tower.transform.position,transform.position)<6){
            NM.enabled=true;NM.SetDestination(fox9.position);anim.SetBool("walk",true);
            transform.LookAt(new Vector3(fox9.transform.position.x,transform.position.y,fox9.transform.position.z));
        }
        if(fox9healthbar!=null&&Vector3.Distance(fox9.transform.position,Player1.transform.position)<4&&Vector3.Distance(fox9.transform.position,transform.position)<= 2.3&&Vector3.Distance(tower.transform.position,transform.position)<6){
            NM.enabled=true;NM.SetDestination(fox9.position);anim.SetBool("walk",false);
            anim.SetTrigger("attack1");
            transform.LookAt(new Vector3(fox9.transform.position.x,transform.position.y,fox9.transform.position.z));
        }
        if(fox10healthbar!=null&&Vector3.Distance(fox10.transform.position,Player1.transform.position)<4&&Vector3.Distance(fox10.transform.position,transform.position)>2.3&&Vector3.Distance(tower.transform.position,transform.position)<6){
            NM.enabled=true;NM.SetDestination(fox10.position);anim.SetBool("walk",true);
            transform.LookAt(new Vector3(fox10.transform.position.x,transform.position.y,fox10.transform.position.z));
        }
        if(fox10healthbar!=null&&Vector3.Distance(fox10.transform.position,Player1.transform.position)<4&&Vector3.Distance(fox10.transform.position,transform.position)<=2.3&&Vector3.Distance(tower.transform.position,transform.position)<6){
            NM.enabled=true;NM.SetDestination(fox10.position);anim.SetBool("walk",false);
            anim.SetTrigger("attack1");
            transform.LookAt(new Vector3(fox10.transform.position.x,transform.position.y,fox10.transform.position.z));
        }
        if(fox11healthbar!=null&&Vector3.Distance(fox11.transform.position,Player1.transform.position)<4&&Vector3.Distance(fox11.transform.position,transform.position)>2.3&&Vector3.Distance(tower.transform.position,transform.position)<6){
            NM.enabled=true;NM.SetDestination(fox11.position);anim.SetBool("walk",true);
            transform.LookAt(new Vector3(fox11.transform.position.x,transform.position.y,fox11.transform.position.z));
        }
        if(fox11healthbar!=null&&Vector3.Distance(fox11.transform.position,Player1.transform.position)<4&&Vector3.Distance(fox11.transform.position,transform.position)<=2.3&&Vector3.Distance(tower.transform.position,transform.position)<6){
            NM.enabled=true;NM.SetDestination(fox11.position);anim.SetBool("walk",false);
            anim.SetTrigger("attack1");
            transform.LookAt(new Vector3(fox11.transform.position.x,transform.position.y,fox11.transform.position.z));
        }
        if(fox12healthbar!=null&&Vector3.Distance(fox12.transform.position,Player1.transform.position)<4&&Vector3.Distance(fox12.transform.position,transform.position)>2.3&&Vector3.Distance(tower.transform.position,transform.position)<6){
            NM.enabled=true;NM.SetDestination(fox12.position);anim.SetBool("walk",true);
            transform.LookAt(new Vector3(fox12.transform.position.x,transform.position.y,fox12.transform.position.z));
        }
        if(fox12healthbar!=null&&Vector3.Distance(fox12.transform.position,Player1.transform.position)<4&&Vector3.Distance(fox12.transform.position,transform.position)<=2.3&&Vector3.Distance(tower.transform.position,transform.position)<6){
            NM.enabled=true;NM.SetDestination(fox12.position);anim.SetBool("walk",false);
            anim.SetTrigger("attack1");
            transform.LookAt(new Vector3(fox12.transform.position.x,transform.position.y,fox12.transform.position.z));
        }
        if(fox13healthbar!=null&&Vector3.Distance(fox13.transform.position,Player1.transform.position)<4&&Vector3.Distance(fox13.transform.position,transform.position)>2.3&&Vector3.Distance(tower.transform.position,transform.position)<6){
            NM.enabled=true;NM.SetDestination(fox13.position);anim.SetBool("walk",true);
            transform.LookAt(new Vector3(fox13.transform.position.x,transform.position.y,fox13.transform.position.z));
        }
        if(fox13healthbar!=null&&Vector3.Distance(fox13.transform.position,Player1.transform.position)<4&&Vector3.Distance(fox13.transform.position,transform.position)<=2.3&&Vector3.Distance(tower.transform.position,transform.position)<6){
            NM.enabled=true;NM.SetDestination(fox13.position);anim.SetBool("walk",false);
            anim.SetTrigger("attack1");
            transform.LookAt(new Vector3(fox13.transform.position.x,transform.position.y,fox13.transform.position.z));
        }
        if(fox14healthbar!=null&&Vector3.Distance(fox14.transform.position,Player1.transform.position)<4&&Vector3.Distance(fox14.transform.position,transform.position)>2.3&&Vector3.Distance(tower.transform.position,transform.position)<6){
            NM.enabled=true;NM.SetDestination(fox14.position);anim.SetBool("walk",true);
            transform.LookAt(new Vector3(fox14.transform.position.x,transform.position.y,fox14.transform.position.z));
        }
        if(fox14healthbar!=null&&Vector3.Distance(fox14.transform.position,Player1.transform.position)<4&&Vector3.Distance(fox14.transform.position,transform.position)<=2.3&&Vector3.Distance(tower.transform.position,transform.position)<6){
            NM.enabled=true;NM.SetDestination(fox14.position);anim.SetBool("walk",false);
            anim.SetTrigger("attack1");
            transform.LookAt(new Vector3(fox14.transform.position.x,transform.position.y,fox14.transform.position.z));
        }
        if(fox15healthbar!=null&&Vector3.Distance(fox15.transform.position,Player1.transform.position)<4&&Vector3.Distance(fox15.transform.position,transform.position)>2.3&&Vector3.Distance(tower.transform.position,transform.position)<6){
            NM.enabled=true;NM.SetDestination(fox15.position);anim.SetBool("walk",true);
            transform.LookAt(new Vector3(fox15.transform.position.x,transform.position.y,fox15.transform.position.z));
        }
        if(fox15healthbar!=null&&Vector3.Distance(fox15.transform.position,Player1.transform.position)<4&&Vector3.Distance(fox15.transform.position,transform.position)<=2.3&&Vector3.Distance(tower.transform.position,transform.position)<6){
            NM.enabled=true;NM.SetDestination(fox15.position);anim.SetBool("walk",false);
            anim.SetTrigger("attack1");
            transform.LookAt(new Vector3(fox15.transform.position.x,transform.position.y,fox15.transform.position.z));
        }
        if(fox16healthbar!=null&&Vector3.Distance(fox16.transform.position,Player1.transform.position)<4&&Vector3.Distance(fox16.transform.position,transform.position)>2.3&&Vector3.Distance(tower.transform.position,transform.position)<6){
            NM.enabled=true;NM.SetDestination(fox16.position);anim.SetBool("walk",true);
            transform.LookAt(new Vector3(fox16.transform.position.x,transform.position.y,fox16.transform.position.z));
        }
        if(fox16healthbar!=null&&Vector3.Distance(fox16.transform.position,Player1.transform.position)<4&&Vector3.Distance(fox16.transform.position,transform.position)<=2.3&&Vector3.Distance(tower.transform.position,transform.position)< 6){
            NM.enabled=true;NM.SetDestination(fox16.position);anim.SetBool("walk",false);
            anim.SetTrigger("attack1");
            transform.LookAt(new Vector3(fox16.transform.position.x,transform.position.y,fox16.transform.position.z));
        }
        if(fox17healthbar!=null&&Vector3.Distance(fox17.transform.position,Player1.transform.position)<4&&Vector3.Distance(fox17.transform.position,transform.position)>2.3&&Vector3.Distance(tower.transform.position,transform.position)<6){
            NM.enabled=true;NM.SetDestination(fox17.position);anim.SetBool("walk",true);
            transform.LookAt(new Vector3(fox17.transform.position.x,transform.position.y,fox17.transform.position.z));
        }
        if(fox17healthbar!=null&&Vector3.Distance(fox17.transform.position,Player1.transform.position)<4&&Vector3.Distance(fox17.transform.position,transform.position)<=2.3&&Vector3.Distance(tower.transform.position,transform.position)<6){
            NM.enabled=true;NM.SetDestination(fox17.position);anim.SetBool("walk",false);
            anim.SetTrigger("attack1");
            transform.LookAt(new Vector3(fox17.transform.position.x,transform.position.y,fox17.transform.position.z));
        }
        if(fox18healthbar!=null&&Vector3.Distance(fox18.transform.position,Player1.transform.position)<4&&Vector3.Distance(fox18.transform.position,transform.position)>2.3&&Vector3.Distance(tower.transform.position,transform.position)<6){
            NM.enabled=true;NM.SetDestination(fox18.position);anim.SetBool("walk",true);
            transform.LookAt(new Vector3(fox18.transform.position.x,transform.position.y,fox18.transform.position.z));
        }
        if(fox18healthbar!=null&&Vector3.Distance(fox18.transform.position,Player1.transform.position)<4&&Vector3.Distance(fox18.transform.position,transform.position)<=2.3&&Vector3.Distance(tower.transform.position,transform.position)<6){
            NM.enabled=true;NM.SetDestination(fox18.position);anim.SetBool("walk",false);
            anim.SetTrigger("attack1");
            transform.LookAt(new Vector3(fox18.transform.position.x,transform.position.y,fox18.transform.position.z));
        }
        if(fox19healthbar!=null&&Vector3.Distance(fox19.transform.position,Player1.transform.position)<4&&Vector3.Distance(fox19.transform.position,transform.position)>2.3&&Vector3.Distance(tower.transform.position,transform.position)<6){
            NM.enabled=true;NM.SetDestination(fox19.position);anim.SetBool("walk",true);
            transform.LookAt(new Vector3(fox19.transform.position.x,transform.position.y,fox19.transform.position.z));
        }
        if(fox19healthbar!=null&&Vector3.Distance(fox19.transform.position,Player1.transform.position)<4&&Vector3.Distance(fox19.transform.position,transform.position)<=2.3&&Vector3.Distance(tower.transform.position,transform.position)<6){
            NM.enabled=true;NM.SetDestination(fox19.position);anim.SetBool("walk",false);
            anim.SetTrigger("attack1");
            transform.LookAt(new Vector3(fox19.transform.position.x,transform.position.y,fox19.transform.position.z));
        }
        if(bull1healthbar!=null&&Vector3.Distance(bull1.transform.position,Player1.transform.position)<4&&Vector3.Distance(bull1.transform.position,transform.position)>2.3){
            NM.enabled=true;NM.SetDestination(bull1.position);anim.SetBool("walk",true);
            transform.LookAt(new Vector3(bull1.transform.position.x,transform.position.y,bull1.transform.position.z));
        }
        if(bull1healthbar!=null&&Vector3.Distance(bull1.transform.position,Player1.transform.position)<4&&Vector3.Distance(bull1.transform.position,transform.position)<=2.3){
            NM.enabled=true;NM.SetDestination(bull1.position);anim.SetBool("walk",false);
            anim.SetTrigger("attack1");
            transform.LookAt(new Vector3(bull1.transform.position.x,transform.position.y,bull1.transform.position.z));
        }
        if(bull2healthbar!=null&&Vector3.Distance(bull2.transform.position,Player1.transform.position)<4&&Vector3.Distance(bull2.transform.position,transform.position)>2.3){
            NM.enabled=true;NM.SetDestination(bull2.position);anim.SetBool("walk",true);
            transform.LookAt(new Vector3(bull2.transform.position.x,transform.position.y,bull2.transform.position.z));
        }
        if(bull2healthbar!=null&&Vector3.Distance(bull2.transform.position,Player1.transform.position)<4&&Vector3.Distance(bull2.transform.position,transform.position)<=2.3){
            NM.enabled=true;NM.SetDestination(bull2.position);anim.SetBool("walk",false);
            anim.SetTrigger("attack1");
            transform.LookAt(new Vector3(bull2.transform.position.x,transform.position.y,bull2.transform.position.z));
        }
        if(bull3healthbar!=null&&Vector3.Distance(bull3.transform.position,Player1.transform.position)<4&&Vector3.Distance(bull3.transform.position,transform.position)>2.3){
            NM.enabled=true;NM.SetDestination(bull3.position);anim.SetBool("walk",true);
            transform.LookAt(new Vector3(bull3.transform.position.x,transform.position.y,bull3.transform.position.z));
        }
        if(bull3healthbar!=null&&Vector3.Distance(bull3.transform.position,Player1.transform.position)<4&&Vector3.Distance(bull3.transform.position,transform.position)<=2.3){
            NM.enabled=true;NM.SetDestination(bull3.position);anim.SetBool("walk",false);
            anim.SetTrigger("attack1");
            transform.LookAt(new Vector3(bull3.transform.position.x,transform.position.y,bull3.transform.position.z));
        }
    }
}