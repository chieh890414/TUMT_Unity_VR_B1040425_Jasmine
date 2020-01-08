using UnityEngine;

public class one : MonoBehaviour
{
    public static bool OneEnter;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "方塊" || collision.gameObject.tag == "球")
        {
            OneEnter = true;
            print("1");
        }
    }
}
