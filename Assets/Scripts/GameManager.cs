using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    int Ran1 = 0;
    int Ran2 = 0;
    public Text Rantext1;
    public Text Rantext2;
    Text text;
    public Button[] button;
    public Text[] t;
    // Use this for initialization
    void Start()
    {
        text = GetComponent<Text>();
        Ran1 = Random.Range(1, 999);
        Ran2 = Random.Range(1, 999);
        Rantext1.text = Ran1.ToString();
        Rantext2.text = Ran2.ToString();
        text.text = "+";//(Ran1 + Ran2).ToString();
        for (int i = 0; i < button.Length; ++i)
        {
            t[i] = button[i].GetComponentInChildren<Text>();
        }
        int[] num = new int[3];
        num[0] = Random.Range(-1, 1);
        for (int i = 0; i < t.Length; ++i)
        {
            t[i].text = (Ran1 + Ran2 - 1 + i).ToString();
        }
    }
}
