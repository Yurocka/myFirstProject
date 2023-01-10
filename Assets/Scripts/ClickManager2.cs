using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickManager2 : MonoBehaviour
{
int slava = 0;

int danya = 1;

public Text text;

void Start()
{
    print("World hello");

}
public void Clack()
{
    slava += danya;

}
}
