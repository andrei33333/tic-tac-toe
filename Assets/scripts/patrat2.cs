using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class patrat2 : MonoBehaviour
{
    public int row, column;

    // Start is called before the first frame update
    private void OnMouseDown()
    {
        if (patrat1.table[row, column] == -1)
        {
            transform.GetChild(0).GetComponent<TMP_Text>().text = patrat1.counter % 2 == 0 ? "X" : "0";
            patrat1.table[row, column] = patrat1.counter % 2;//daca e 0 e x altfel daca e 1 e zero
            patrat1.counter++;
            patrat1.lst[patrat1.lp++] = 0;
            patrat1.cst[patrat1.cp++] = 1;
        }

    }
    // Update is called once per frame
}
