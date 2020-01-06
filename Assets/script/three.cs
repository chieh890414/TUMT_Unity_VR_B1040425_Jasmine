using UnityEngine;

public class three : MonoBehaviour
{
    public static bool ThreeEnter;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "圓柱")
        {
            ThreeEnter = true;
            print("3");
        }
    }
}
