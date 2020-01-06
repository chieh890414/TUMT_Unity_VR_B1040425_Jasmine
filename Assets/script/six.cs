using UnityEngine;

public class six : MonoBehaviour
{
    public static bool SixEnter;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "方塊" || collision.gameObject.tag == "球" && collision.gameObject.tag == "膠囊" && collision.gameObject.tag == "圓柱")
        {
            SixEnter = true;
            print("6");
        }
    }
}
