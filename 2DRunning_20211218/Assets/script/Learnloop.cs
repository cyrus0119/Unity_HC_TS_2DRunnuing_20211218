using UnityEditor;
using UnityEngine;
/// <summary>
/// 迴圈
/// 1.while
/// 2.do 
/// 3.for
/// 4.foreach
/// </summary>
public class Learnloop : MonoBehaviour
{
    //迴圈作用
    //處理重複程式
    private void Start()
    {
        //輸出5次哈囉 非迴圈
        /*
        print("哈囉");
        print("哈囉");
        print("哈囉");
        print("哈囉");
        print("哈囉");
        */

        // while 迴圈語法與 if 相同
        // if (布林值) {程式區塊};
        // while (布林值) {程式區塊};
        //無限迴圈
        /*
        while(true)
        {
            print(迴圈while);
        }
        */
        int count = 0;
        while (count<5)
        {
            print("哈囉");
            count++;
        }

        //for迴圈(初始值; 布林值; 迴圈結束會執行程式)
        for (int i = 0; i < 5; i++)
        {
            print("哈囉" + i );
        }
        //輸出數字0-100 以5遞增
        for (int i = 0; i < 101; i+=5)
        {
            print("輸出數字:" + i);
        }
    }

}
