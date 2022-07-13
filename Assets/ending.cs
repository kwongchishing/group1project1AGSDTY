using UnityEngine;
using UnityEngine.SceneManagement;
public class ending:MonoBehaviour{
    public GameObject Text4,girl,Text5,Text3,Text2,Text1;
    public void girlmove()
    {
        girl.GetComponent<Animator>().SetBool("idle",true);
        Text1.SetActive(true);
    }
    public void fathertalk()
    {
        Text1.SetActive(false);
        Text2.SetActive(true);
    }
    public void girltalk()
    {
        Text2.SetActive(false);
        Text3.SetActive(true);
    }
    public void endtalk()
    {
        Text3.SetActive(false);
        Text4.SetActive(true);
    }
    public void tobecontinued()
    {
        Text4.SetActive(false);
        Text5.SetActive(true);
    }
    public void backtomenu()
    {
        SceneManager.LoadScene("title");
    }
}
