using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;
/// <summary>
/// 學習判斷式
/// 1. if
/// 2. switch
/// </summary>
public class Learncondition : MonoBehaviour
{
    public bool faskey = true ;
    public int combo = 0;
    public string weapon;

    // 列舉 enum (下拉式選單)
    // 1. 定義列舉
    public enum Season
        {
            spring, summer, fall, winter
        }
    // 2. 實作列舉
    public Season season;

    private void Start()
    {
        #region if 判斷式
        // if 語法
        // if (布林值) {程式區塊、演算法、陳述式}
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
        #endregion

        //switch 語法
        //switch 判斷的資料
        //{
        //  case 值1:
        //      程式內容;
        //      斷開;
        //  case 值2:
        //      程式內容;
        //      斷開;
        //  default:
        //      程式內容;
        //      斷開;
        //}

        switch (weapon)
        {
          case "單手劍":
              print("akt 10");
              break;
            case "雙手劍":
                print("akt 30");
                break;
            case "闊劍":
                print("akt 20");
                break;
            default:
                print("這不是武器");
                break;
        }
    }

    private void Update()
    {
        #region if 判斷式2  
        //else if 必須在 if 下方 沒有數量限制
        //else if (布林值) {程式區塊、演算法、陳述式}
        //連擊等於10攻擊力加10
        if (combo == 10) 
        {
            print("攻擊力加10");
        }
        //連擊等於100攻擊力加100
        else if (combo == 100)
        {
            print("攻擊力加100");
        }
        //連擊等於500攻擊力加500
        else if (combo == 500)
        {
            print("攻擊力加500");
        }
        #endregion
    }

}
