using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    bool isActiveAnim; //всегда изначально false
    public Transform Object;

    public void Click()
    {
        // false -> true или true -> false
        isActiveAnim = !isActiveAnim;
        // так же можно isActiveAnim = true; или isActiveAnim = false;
    }

    private void FixedUpdate()
    {
        if(isActiveAnim == true)
        {
            Object.Rotate(0, 0, 3);
            // x y z
        }
    }
}
