using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    bool isActiveAnim; //всегда изначально false
    float speed = 0.5f;
    public Transform Object;

    public void Click()
    {
        // false -> true или true -> false
        isActiveAnim = !isActiveAnim;
        // так же можно isActiveAnim = true; или isActiveAnim = false;

        print("switch");
    }

    private void FixedUpdate()
    {
        if(isActiveAnim == true)
        {
            Object.Rotate(0, 0, 3);

            Object.Translate(Object.forward * speed * Time.deltaTime);
            // -Object.
            // Object.right
            // -Object.right
            // Object.forward
            // -Object.forward

            // rjfhsjfhksjfjsfjkshfkshfk

            // x y z
        }
    }
}
