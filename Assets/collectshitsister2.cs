using UnityEngine;
public class collectshitsister2:MonoBehaviour
{
    public GameObject shit;
    public save2 save2;
    public petlove2 petlove;
    public AudioSource getitem;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            getitem.Play();
            shit.SetActive(false);
            save2.shitcount++;
            petlove.isshit = false;
            this.gameObject.SetActive(false);
        }
    }
}