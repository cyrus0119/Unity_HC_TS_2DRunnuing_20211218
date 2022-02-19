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
        //輸出5次哈囉
        print("哈囉");
        print("哈囉");
        print("哈囉");
        print("哈囉");
        print("哈囉");

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
    }

}
