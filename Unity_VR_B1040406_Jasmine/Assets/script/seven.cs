using UnityEngine;

public class seven : MonoBehaviour
{
    public static bool SevenEnter;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "方塊" && collision.gameObject.tag == "球" && collision.gameObject.tag == "膠囊" && collision.gameObject.tag == "圓柱")
        {
            SevenEnter = true;
            print("7");
        }
    }
}
