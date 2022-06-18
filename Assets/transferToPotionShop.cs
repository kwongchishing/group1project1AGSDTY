using UnityEngine;public class transferToPotionShop:MonoBehaviour{
    GameObject Player;
    public Ischange Ischange;
    public AudioSource bg1,bg2,potionShopSong,opendoorsound;
    public save2 save2;
    public float distance;
    public Transform p1,p2;
    public GameObject Player2,newbgm1,mmpointer,pstonepointer,realPotionHouse,minimap,oldmmpointer;
    void Update(){
        distance=Vector3.Distance(p1.transform.position, p2.transform.position);
        if(Input.GetKeyDown(KeyCode.Return)|Input.GetKeyDown(KeyCode.E)){
            Player=GameObject.FindWithTag("Player");
            if(save2.finishgame<1) realPotionHouse.SetActive(true);
            minimap.SetActive(false); opendoorsound.Play();
            if(save2.finishgame<1){
                Player.transform.position=new Vector3(407.262665f,50.4073571f,278.663574f);
                Player.transform.rotation=Quaternion.Euler(0,261.958008f,0);
            }
            if(save2.finishgame >0){
                Player.transform.position=new Vector3(978.352478f,-131.705948f,125.356682f);
                Player.transform.rotation=Quaternion.Euler(0,261.958008f,0);
            }
            mmpointer.SetActive(false);
            Player.GetComponent<Animator>().SetBool("nojump",true);            
            if(Ischange.ischange<1){bg1.Stop();potionShopSong.Play();}
            if(Ischange.ischange>0&&save2.collectedkey<1){bg2.Stop();potionShopSong.Play();}
            if(Ischange.ischange>0&&save2.collectedkey>0){bg1.Stop();potionShopSong.Play();}
            if(pstonepointer!=null) pstonepointer.SetActive(false);
            if(oldmmpointer!=null) oldmmpointer.SetActive(false);
            if(save2.finishgame>0){
                newbgm1.SetActive(false);
                save2.isinshop=true;
            }
            if(distance<=8f&&save2.isjoined==true){
                save2.isinshop=true;
                Player2.transform.position=new Vector3(979.0994873046875f,-130.95004272460938f,124.46919250488281f);
                    Player2.transform.rotation=Quaternion.Euler(0,261.958008f,0);Player2.GetComponent<Animator>().SetBool("nojump",true);
                }
        }
    }}