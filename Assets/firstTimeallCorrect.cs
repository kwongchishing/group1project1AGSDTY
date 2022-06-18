using UnityEngine;public class firstTimeallCorrect:MonoBehaviour{
public GameObject entertocontinue,mathsNPCcollider,pressEnterornot,player,MathstestPanel,canDestroy1,canDestroy2,canDestroy3,canDestroy4,canDestroy5,canDestroy6,canDestroy7,canDestroy8,canDestroy9,minimapiconthrowhouse,minimapiconmchouse;
    public AudioSource test1Music,cancelTestsound;
    public correctCount cc;
    void Update(){
        test1Music.Stop();
        if(Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.E))
        {
            player.SetActive(false);
            player.SetActive(true);
            player.GetComponent<Rigidbody>().constraints=RigidbodyConstraints.FreezeRotationX|RigidbodyConstraints.FreezeRotationY|RigidbodyConstraints.FreezeRotationZ;
            player.transform.position=new Vector3(319.32f,50.4061f,277.33f);
            player.transform.rotation=Quaternion.Euler(0f,-90f,0f);
            player.gameObject.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl>().enabled=true;
            mathsNPCcollider.SetActive(true);
            pressEnterornot.SetActive(true);
            cancelTestsound.Play();
            cc.retryOrnot=1;
            Destroy(MathstestPanel);
            entertocontinue.SetActive(false);
            Destroy(canDestroy1);
            Destroy(canDestroy2);
            Destroy(canDestroy3);
            Destroy(canDestroy4);
            Destroy(canDestroy5);
            Destroy(canDestroy6);
            Destroy(canDestroy7);
            Destroy(canDestroy8);
            Destroy(canDestroy9);
            minimapiconthrowhouse.SetActive(true);
            minimapiconmchouse.SetActive(false);
            this.gameObject.SetActive(false);
        }
    }
}