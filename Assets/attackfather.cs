using UnityEngine;public class attackfather:MonoBehaviour{
    public AudioSource fatherhit;
    bool trig;
    public AXE_lighting checklight;
    public save2 save2;
    void Update(){
        if(trig && checklight.lighting)
        {
            fatherhit.Play();
            save2.fatherhurt++;
            Destroy(this.gameObject);
        }
        if (trig && checklight.heavying)
        {
            fatherhit.Play();
            save2.fatherhurt++;
            Destroy(this.gameObject);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "AXE")
        {
            trig = true;
        }        
        if (other.gameObject.tag == "combo3storm")
        {
            fatherhit.Play();
            save2.fatherhurt++;
            Destroy(this.gameObject);
        }
        if (other.gameObject.tag == "electricskill")
        {
            fatherhit.Play();
            save2.fatherhurt++;
            Destroy(this.gameObject);
        }
        if (other.gameObject.tag == "sisterweapon")
        {
            fatherhit.Play();
            save2.fatherhurt++;
            Destroy(this.gameObject);
        }
        if (other.gameObject.tag == "sisterheavyweapon")
        {
            fatherhit.Play();
            save2.fatherhurt++;
            Destroy(this.gameObject);
        }
        if (other.gameObject.tag == "p2lightattack")
        {
            fatherhit.Play();
            save2.fatherhurt++;
            Destroy(this.gameObject);
        }
        if (other.gameObject.tag == "p2heavyattack")
        {
            fatherhit.Play();
            save2.fatherhurt++;
            Destroy(this.gameObject);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "AXE")
        {
            trig = false;
        }
    }
}