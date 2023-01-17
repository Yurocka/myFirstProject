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

    int countClick = 0;
    int upgrate = 1;
    string lalala = "alo";
    bool check;
    public Text text;
    public Text Lowe;
    int avto = 0;


    int[] array = new int[] { 1, 2, 3, 0 };



    void Start()
    {

        array = new int[] { 10, 100, 1000 };
        print(array[array.Length - 2]);
        print("hello world");
        array[1] = 69;
        for (int i = 0; i < array.Length; i++)
        {
            print(array[i]);
        }

        countClick = PlayerPrefs.GetInt("count");
        if (PlayerPrefs.GetInt("Apgreit") != 0)
        {
            upgrate = PlayerPrefs.GetInt("Apgreit");
        }
        text.text = countClick.ToString();
        Lowe.text = "сила клика " + upgrate.ToString();

        StartCoroutine(TimeFlow());
    }
    private IEnumerator TimeFlow()
    {

        while (true)
        {
            countClick += avto;
            text.text = countClick.ToString();
            yield return new WaitForSeconds(1);
        }
    }
    public void Clack()
    {
        avto += 1;
    }
    public void Click()
    {
        countClick += upgrate; // count = count + 1;

        PlayerPrefs.SetInt("count", countClick);

        text.text = countClick.ToString();

        print(countClick);
    }
    public void Upgrate()
    {
        upgrate += 1;
        PlayerPrefs.SetInt("Apgreit", upgrate);
        if (countClick == 10)
        {
            // если count равен 10 то выполняется то что внутри
            print("count равен 10!!!");
        }
        else if (countClick > 10)
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
        countClick = 0;
        upgrate = 1;
        avto = 0;
        text.text = countClick.ToString();

        Lowe.text = "сила клика " + upgrate.ToString();

    }
}
