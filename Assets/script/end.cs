using UnityEngine;
using UnityEngine.UI;

public class end : MonoBehaviour
{
    public Text say;
    private void Update()
    {
        if (one.OneEnter && two.TwoEnter && three.ThreeEnter && four.FourEnter && five.FiveEnter && six.SixEnter && seven.SevenEnter)
        {
            say.text = "恭喜完成我的期末遊戲~~~";
        }
        else
        {
            say.text = "方塊=1圓形=1 膠囊=2圓柱=3 不可使用相同形狀";
        }
    }
}
