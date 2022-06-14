using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menukontrol : MonoBehaviour
{
    public void oyunaGit()
    {
        int kayitlilevel = PlayerPrefs.GetInt("kayit");
        if (kayitlilevel == 0)
        {
            SceneManager.LoadScene(kayitlilevel+1);
        }
        else
        {
            SceneManager.LoadScene(kayitlilevel);
        }
    }
    public void sifirla()
    {
        PlayerPrefs.DeleteAll();
    }
    public void cik()
    {
        Application.Quit();
    }
    public void Start()
    {
  
    }
}
