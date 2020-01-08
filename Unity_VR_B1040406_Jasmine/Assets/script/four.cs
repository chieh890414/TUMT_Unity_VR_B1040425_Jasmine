using UnityEngine;

public class four : MonoBehaviour
{
    public static bool FourEnter;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "方塊" && collision.gameObject.tag == "球" && collision.gameObject.tag == "膠囊")
        {
            FourEnter = true;
            print("4");
        }
    }
}
