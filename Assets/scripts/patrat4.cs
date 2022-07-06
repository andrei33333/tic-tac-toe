using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class patrat4 : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnMouseDown()
    {
        if (patrat1.table[1, 0] == -1)
        {
            transform.GetChild(0).GetComponent<TMP_Text>().text = patrat1.counter % 2 == 0 ? "X" : "0";
            patrat1.table[1, 0] = patrat1.counter % 2;//daca e 0 e x altfel daca e 1 e zero
            patrat1.counter++;
            patrat1.lst[patrat1.lp++] = 1;
            patrat1.cst[patrat1.cp++] = 0;
        }

    }
}
