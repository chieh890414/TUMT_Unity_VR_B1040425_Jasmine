using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class five : MonoBehaviour
{
    public static bool FiveEnter;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "膠囊" && collision.gameObject.tag == "圓柱")
        {
            FiveEnter = true;
            print("5");
        }
    }
}
