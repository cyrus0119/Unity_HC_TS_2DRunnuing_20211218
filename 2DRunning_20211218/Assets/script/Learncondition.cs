using UnityEditor;
using UnityEngine;
/// <summary>
/// 學習判斷式
/// 1. if
/// 2. switch
/// </summary>
public class Learncondition : MonoBehaviour
{
    public bool faskey = true ;
    public int combo = 0;

    private void Start()
    {
        // if 語法
        // in (布林值) {程式區塊、演算法、陳述式}
        //快速完成 if + tab*2
        //布林值等於 true 會執行{}內的程式
        //          false 不執行

        if (true)
        {
            print("if判斷式測試");
        }

        //開門判斷式

        if (faskey)
        {
            print("FBI OPEN THE DOOR");
        }
        else
        {
            print("kotowaru");
        }
    }

    private void Update()
    {
        if (combo == 10) 
        {
            print("攻擊力加10");
        }
        else if (combo == 100)
        {
            print("攻擊力加100");
        }
        else if (combo == 500)
        {
            print("攻擊力加500");
        }
    }

}
