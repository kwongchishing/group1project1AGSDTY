using UnityEngine;public class bossAppear1:MonoBehaviour{
    public GameObject boss1,Player,talkboss1Text1,AXE;
    public AXE_lighting AXE_lighting;
    Animator anim;
    public save2 save2;
    void Start(){anim=Player.GetComponent<Animator>();}
    void Update(){
        if(Input.GetKeyDown(KeyCode.Return)|| Input.GetKeyDown(KeyCode.E))
        {            
            Player.GetComponent<Rigidbody>().constraints=RigidbodyConstraints.FreezePositionX|RigidbodyConstraints.FreezePositionZ|RigidbodyConstraints.FreezeRotationX|RigidbodyConstraints.FreezeRotationY|RigidbodyConstraints.FreezeRotationZ;
            AXE_lighting.lighting=false;
            AXE_lighting.heavying=false;
            boss1.SetActive(true);
            talkboss1Text1.SetActive(true);
            save2.collectedkey+=1;
            Player.transform.position=new Vector3(-9.18177128f,0.0675587752f,-303.492157f);
            Player.transform.rotation=Quaternion.Euler(0,90.0147095f,0);
            AXE.transform.position=new Vector3(0.100000001f,0.209999993f,0.0700000003f);
            AXE.transform.rotation=Quaternion.Euler(356.056854f,205.06723f,340.97644f);
            Destroy(this.gameObject);}}}