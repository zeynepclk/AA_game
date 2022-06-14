using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class oyunyoneticisi : MonoBehaviour
{
    GameObject donencember;
    GameObject anacember;
    public Animator animator;
    public Text level;
    public Text bir;
    public Text iki;
    public Text uc;
    public int cembersayisi;
    bool kontrol = true;
    void Start()
    {
        PlayerPrefs.SetInt("kayit", int.Parse(SceneManager.GetActiveScene().name));
        int gelenDeger= PlayerPrefs.GetInt("kayit");

        donencember = GameObject.FindGameObjectWithTag("donencembertag");
        anacember = GameObject.FindGameObjectWithTag("anacembertag");
        level.text = SceneManager.GetActiveScene().name;
  
        if(cembersayisi<2)
        {
            bir.text = cembersayisi + "";
        }
        else if(cembersayisi<3)
        {
            bir.text = cembersayisi + "";
            iki.text = (cembersayisi - 1) + "";
        }
        else 
        {
            bir.text = cembersayisi + "";
            iki.text = (cembersayisi - 1) + "";
            uc.text = (cembersayisi - 2) + "";
        }
    }
    public void CemberTextGosterme()
    {
        cembersayisi--;
        if (cembersayisi < 2)
        {
            bir.text = cembersayisi + "";
            iki.text = "";
            uc.text = "";
        }
        else if (cembersayisi < 3)
        {
            bir.text = cembersayisi + "";
            iki.text = (cembersayisi - 1) + "";
            uc.text = "";
        }
        else
        {
            bir.text = cembersayisi + "";
            iki.text = (cembersayisi - 1) + "";
            uc.text = (cembersayisi - 2) + "";
        }
        if(cembersayisi==0)
        {         
            StartCoroutine(yeniLevel());
        }
    }
    IEnumerator yeniLevel()
    {
        donencember.GetComponent<dondurme>().enabled = false;
        anacember.GetComponent<anacember>().enabled = false;
        yield return new WaitForSeconds(0.3f);
        if (kontrol)
        {
        animator.SetTrigger("yenilevel");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(int.Parse(SceneManager.GetActiveScene().name)+ 1);
        }
    }
    public void OyunBitti()
    {
        StartCoroutine(cagrilanmetot());
    }
    IEnumerator cagrilanmetot()
    {
        donencember.GetComponent<dondurme>().enabled = false;
        anacember.GetComponent<anacember>().enabled = false;
        animator.SetTrigger("oyunbitti");
        kontrol =false;

        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("anamenu");
    }
}
