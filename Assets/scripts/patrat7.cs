using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class patrat7 : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnMouseDown()
    {
        if (patrat1.table[2, 0] == -1)
        {
            transform.GetChild(0).GetComponent<TMP_Text>().text = patrat1.counter % 2 == 0 ? "X" : "0";
            patrat1.table[2, 0] = patrat1.counter % 2;//daca e 0 e x altfel daca e 1 e zero
            patrat1.counter++;
            patrat1.lst[patrat1.lp++] = 2;
            patrat1.cst[patrat1.cp++] = 0;
        }

    }

    // Update is called once per frame
}
