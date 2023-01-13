using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickManager : MonoBehaviour
{
    // void - функция
    // int/float - любые числа/дробные числа
    // string - любой текст
    // bool - да/нет

    int count = 0;
    int upgrate = 1;
    string alo = "alo";
    bool check = false;
    public Text text;
    public Text Lowe;
    int avto = 0;

    void Start()
    {
        print("hello world");

        count = PlayerPrefs.GetInt("count");
        if (PlayerPrefs.GetInt("Apgreit") != 0)
        {
            upgrate = PlayerPrefs.GetInt("Apgreit");
        }
        text.text = count.ToString();
        Lowe.text = "сила клика " + upgrate.ToString();

        StartCoroutine(TimeFlow());
    }
    private IEnumerator TimeFlow()
    {

        while (true)
        {
            count += avto;
            text.text = count.ToString();
            yield return new WaitForSeconds(1);
        }
    }
    public void Clack()
    {
        avto += 1;
    }
    public void Click()
    {
        count += upgrate; // count = count + 1;

        PlayerPrefs.SetInt("count", count);

        text.text = count.ToString();

        print(count);
    }
    public void Upgrate()
    {
        upgrate += 1;
        PlayerPrefs.SetInt("Apgreit", upgrate);
        if (count == 10)
        {
            // если count равен 10 то выполняется то что внутри
            print("count равен 10!!!");
        }
        else if (count > 10)
        {
            // если вверхнее условие не сработало проверятеся это
            print("count больше 10!!!");
        }
        else
        {
            print("count меньше 10!!!");
        }

        Lowe.text = "сила клика " + upgrate.ToString();
    }
    public void DeleteData()
    {
        PlayerPrefs.DeleteAll();
        count = 0;
        upgrate = 1;
        avto = 0;
        text.text = count.ToString();

        Lowe.text = "сила клика " + upgrate.ToString();

    }
}
