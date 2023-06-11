using UnityEngine;
using UnityEngine.UI;
using System.Runtime.InteropServices;

public class CppToUnity : MonoBehaviour
{
    [SerializeField]
    InputField inputFieldA;
    [SerializeField]
    InputField inputFieldB;
    [SerializeField]
    Text anserText;

    public void Calc()
    {
        var aIsInt = int.TryParse(inputFieldA.text, out int a);
        var bIsInt = int.TryParse(inputFieldB.text, out int b);
        if (aIsInt && bIsInt)
        {
            // anserText.text = (a + b).ToString();
            var ans = nativeAdd(a, b);
            anserText.text = ans.ToString();
            Debug.LogFormat("{0} + {1} = {2}", a, b, ans);
        }
    }

    [DllImport("CppToUnity")]
    private static extern int nativeAdd(int a, int b);
}
