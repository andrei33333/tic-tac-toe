using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class resetscript : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnMouseDown()
    {
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
                patrat1.table[i, j] = -1;
        GameObject.Find("patrat#1").GetComponent<Transform>().GetChild(0).GetComponent<TMP_Text>().text = " ";
        GameObject.Find("patrat#2").GetComponent<Transform>().GetChild(0).GetComponent<TMP_Text>().text = " ";
        patrat1.iswon = 0;
        patrat1.ngames++;
    }
    // Update is called once per frame
}
