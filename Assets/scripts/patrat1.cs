using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class patrat1 : MonoBehaviour
{
    // Start is called before the first frame update
    public static int counter = 0, lp = 0, cp = 0;
    public static int[,] table = new int[3, 3];
    public static int[] lst = new int[9];
    public static int[] cst = new int[9];
    public static int p1 = 0, p2 = 0, ngames = 1, iswon = 0;

    public void init()
    {
        for(int i = 0; i < 3; i++)
            for(int j = 0; j < 3; j++)
                table[i, j] = -1;
    }
    void Start()
    {
        init();
    }
    private void OnMouseDown()
    {
        if (table[0, 0] == -1)
        {
            transform.GetChild(0).GetComponent<TMP_Text>().text = counter % 2 == 0 ? "X" : "0";
            table[0, 0] = counter % 2;//daca e 0 e x altfel daca e 1 e zero
            ++counter;
            lst[lp++] = 0;
            cst[cp++] = 0;
        }
        
    }
    private void Update()
    {
        transform.GetChild(2).GetComponent<TMP_Text>().text = "Player 1: " + p1;
        transform.GetChild(3).GetComponent<TMP_Text>().text = "Player 2: " + p2;
        if (table[0, 0] == table[0, 1] && table[0, 1] == table[0, 2] && table[0, 0] == 1)
        {
            transform.GetChild(1).GetComponent<TMP_Text>().text = "0 WINNNNNNNNNNNNNNNS";
            if (iswon == 0)
            {
                if (ngames % 2 == 1)
                    p2++;
                else p1++;
            }
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    table[i, j] = 1;
            iswon = 1;
            
        }
        else if (table[0, 0] == table[0, 1] && table[0, 1] == table[0, 2] && table[0, 0] == 0)
        {
            transform.GetChild(1).GetComponent<TMP_Text>().text = "X WINNNNNNNNNNNNNNNS";
            if (iswon == 0)
            {
                if (ngames % 2 == 1)
                    p1++;
                else p2++;
            }
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    table[i, j] = 0;
            iswon = 1;

        }
        else if (table[1, 0] == table[1, 1] && table[1, 1] == table[1, 2] && table[1, 0] == 1)
        {
            transform.GetChild(1).GetComponent<TMP_Text>().text = "0 WINNNNNNNNNNNNNNNS";
            if (iswon == 0)
            {
                if (ngames % 2 == 1)
                    p2++;
                else p1++;
            }
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    table[i, j] = 1;
            iswon = 1;
        }
        else if (table[1, 0] == table[1, 1] && table[1, 1] == table[1, 2] && table[1, 0] == 0)
        {
            transform.GetChild(1).GetComponent<TMP_Text>().text = "X WINNNNNNNNNNNNNNNS";
            if (iswon == 0)
            {
                if (ngames % 2 == 1)
                    p1++;
                else p2++;
            }
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    table[i, j] = 0;
            iswon = 1;

        }
        else if (table[2, 0] == table[2, 1] && table[2, 1] == table[2, 2] && table[2, 0] == 1)
        {
            transform.GetChild(1).GetComponent<TMP_Text>().text = "0 WINNNNNNNNNNNNNNNS";
            if (iswon == 0)
            {
                if (ngames % 2 == 1)
                    p2++;
                else p1++;
            }
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    table[i, j] = 1;
            iswon = 1;

        }
        else if (table[2, 0] == table[2, 1] && table[2, 1] == table[2, 2] && table[2, 0] == 0)
        {
            transform.GetChild(1).GetComponent<TMP_Text>().text = "X WINNNNNNNNNNNNNNNS";
            if (iswon == 0)
            {
                if (ngames % 2 == 1)
                    p1++;
                else p2++;
            }
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    table[i, j] = 0;
            iswon = 1;

        }
        else if (table[0, 0] == table[1, 0] && table[1, 0] == table[2, 0] && table[0, 0] == 1)
        {
            transform.GetChild(1).GetComponent<TMP_Text>().text = "0 WINNNNNNNNNNNNNNNS";
            if (iswon == 0)
            {
                if (ngames % 2 == 1)
                    p2++;
                else p1++;
            }
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    table[i, j] = 1;
            iswon = 1;

        }
        else if (table[0, 1] == table[1, 1] && table[1, 1] == table[2, 1] && table[0, 1] == 0)
        {
            transform.GetChild(1).GetComponent<TMP_Text>().text = "X WINNNNNNNNNNNNNNNS";
            if (iswon == 0)
            {
                if (ngames % 2 == 1)
                    p1++;
                else p2++;
            }
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    table[i, j] = 0;
            iswon = 1;

        }
        else if (table[0, 2] == table[1, 2] && table[1, 2] == table[2, 2] && table[0, 2] == 1)
        {
            transform.GetChild(1).GetComponent<TMP_Text>().text = "0 WINNNNNNNNNNNNNNNS";
            if (iswon == 0)
            {
                if (ngames % 2 == 1)
                    p2++;
                else p1++;
            }
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    table[i, j] = 1;
            iswon = 1;

        }
        else if (table[0, 0] == table[1, 1] && table[1, 1] == table[2, 2] && table[0, 0] == 0)
        {
            transform.GetChild(1).GetComponent<TMP_Text>().text = "X WINNNNNNNNNNNNNNNS";
            if (iswon == 0)
            {
                if (ngames % 2 == 1)
                    p1++;
                else p2++;
            }
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    table[i, j] = 0;
            iswon = 1;

        }
        else if (table[2, 0] == table[1, 1] && table[1, 1] == table[0, 2] && table[2, 0] == 1)
        {
            transform.GetChild(1).GetComponent<TMP_Text>().text = "0 WINNNNNNNNNNNNNNNS";
            if (iswon == 0)
            {
                if (ngames % 2 == 1)
                    p2++;
                else p1++;
            }
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    table[i, j] = 1;
            iswon = 1;

        }
        else if (table[2, 0] == table[1, 1] && table[1, 1] == table[0, 2] && table[2, 0] == 0)
        {
            transform.GetChild(1).GetComponent<TMP_Text>().text = "X WINNNNNNNNNNNNNNNS";
            if (iswon == 0)
            {
                if (ngames % 2 == 1)
                    p1++;
                else p2++;
            }
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    table[i, j] = 1;
            iswon = 1;

        }
        else
        {
            int ok = 1;
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (table[i, j] == -1)
                        ok = 0;
            if (ok == 1)
                transform.GetChild(1).GetComponent<TMP_Text>().text = "DRAWWWWWWWWWWWW";
        }
    }
    // Update is called once per frame
}
