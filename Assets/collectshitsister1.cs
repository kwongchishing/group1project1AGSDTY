using UnityEngine;
public class collectshitsister1: MonoBehaviour
{
    public GameObject shit;
    public save2 save2;
    public petlove petlove;
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