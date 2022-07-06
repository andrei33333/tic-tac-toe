using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Undob : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    private void OnMouseDown()
    {
        if(patrat1.lp > 0)
        {
            patrat1.lp--;
            patrat1.cp--;
            if (patrat1.lst[patrat1.lp] == 0)
            {
                if (patrat1.cst[patrat1.cp] == 0)
                    GameObject.Find("patrat#1").GetComponent<Transform>().GetChild(0).GetComponent<TMP_Text>().text = " ";
                else if(patrat1.cst[patrat1.cp] == 1)
                    GameObject.Find("patrat#2").GetComponent<Transform>().GetChild(0).GetComponent<TMP_Text>().text = " ";
                else if (patrat1.cst[patrat1.cp] == 2)
                    GameObject.Find("patrat#3").GetComponent<Transform>().GetChild(0).GetComponent<TMP_Text>().text = " ";
            }
        }
    }
    void Update()
    {
        
    }
}
