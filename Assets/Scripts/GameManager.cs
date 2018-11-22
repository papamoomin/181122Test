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
    public Button[] button;
    public Text[] t;
    // Use this for initialization
    void Start()
    {
        Ran1 = Random.Range(1, 999);
        Ran2 = Random.Range(1, 999);
        Rantext1.text = Ran1.ToString();
        Rantext2.text = Ran2.ToString();
        MakeOption();
    }

    public void MakeOption()
    {
        Stack<int> plusNum = new Stack<int>();
        while (plusNum.Count < 3)
        {
            int a = Random.Range(-1, 2);
            if (!plusNum.Contains(a))
                plusNum.Push(a);
        }

        for (int i = 0; i < button.Length; ++i)
        {
            t[i] = button[i].GetComponentInChildren<Text>();
        }

        for (int i = 0; i < t.Length; ++i)
        {
            t[i].text = (Ran1 + Ran2 + plusNum.Pop()).ToString();
        }
    }
}
