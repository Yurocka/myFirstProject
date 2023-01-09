using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickManager : MonoBehaviour
{
    // void - функция
    // int/float - любые числа
    // string - любой текст
    // bool - да/нет

    int count = 0;
    int upgrate = 1;
    string alo = "alo"; 
    bool check = false;
    public Text text;
    public Text Lowe;

    void Start()
    {
        text.text = alo;

        print("hello world");
    }

    public void Click()
    {
        count += upgrate; // count = count + 1;

        text.text = count.ToString();

        print(count);
    }
    public void Upgrate()
    {
        upgrate += 1;

        if(count == 10)
        {
            // если count равен 10 то выполняется то что внутри
            print("count равен 10!!!");
        }
        else if(count > 10)
        {
            // если вверхнее условие не сработало проверятеся это
            print("count больше 10!!!");
        }
        else
        {
            print("count меньше 10!!!");
        }

        Lowe.text = upgrate.ToString();
    }
}