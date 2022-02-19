using System.Threading;
using UnityEngine;

/// <summary>
/// 學習陣列
/// </summary>

public class Learnarray : MonoBehaviour
{
    //陣列 用於儲存相同類型的多筆資料

    //使用欄位儲存多筆資料
    public int atk1 = 10;
    public int atk2 = 20;
    public int atk3 = 30;

    //陣列語法
    //資料類型[] 加中括號為陣列
    public int[] atks;

    //陣列初始值
    //1.指定陣列陳列資料數量不指定內容
    public float[] speeds = new float [5];

    //2.指定陣列內容
    public string[] props = { "紅水", "藍水", "綠水" };
    public Vector3[] positions = { };
    public bool[] complete = { true, true, true };

    private void Start()
    {
        //存取陣列資料
        //1.存放陣列資料
        //陣列名稱[編號]值
        //將陣列第三筆資料改為66
        atks[2] = 66;
        //2.使用陣列錯誤
        //IndexOutOfRange - 編號不存在
        //atk[3]=99 
    }


}
