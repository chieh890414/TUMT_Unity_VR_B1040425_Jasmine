using UnityEngine;

public class two : MonoBehaviour
{
    public static bool TwoEnter;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "膠囊" )
        {
            TwoEnter = true;
            print("2");
        }
    }
}
