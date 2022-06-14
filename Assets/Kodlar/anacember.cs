using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anacember : MonoBehaviour
{
    public GameObject kucukcember;
    GameObject oyunyonetici;
    void Start()
    {
        oyunyonetici = GameObject.FindGameObjectWithTag("oyunyoneticisitag");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            kucukCemberOlustur();
        }
    }
    void kucukCemberOlustur()
    {
        Instantiate(kucukcember, transform.position, transform.rotation);
        oyunyonetici.GetComponent<oyunyoneticisi>().CemberTextGosterme();
    }
}
