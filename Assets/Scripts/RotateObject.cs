using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    bool isActiveAnim; //всегда изначально false
    float speed = 100;
    public Transform Object;
    Vector2 startPos;

    void Start()
    {
        startPos = Object.position;
    }
    public void Click()
    {
        // false -> true или true -> false
        isActiveAnim = !isActiveAnim;
        // так же можно isActiveAnim = true; или isActiveAnim = false;

        print("switch");

        Object.position = startPos;
    }

    private void FixedUpdate()
    {
        Object.Translate(new Vector2(5, 5) * speed * Time.deltaTime);
        //     if(isActiveAnim == true)
        //     {
        //     Object.Rotate(5, 5, 0);

        // Object.Translate(-Object.up * speed * Time.deltaTime);
        // -Object.
        // Object.right
        // -Object.right
        // Object.forward
        // -Object.forward
        // Object.Translate(Object.right * speed * Time.deltaTime);

        // x y z
        // }
    }
}
