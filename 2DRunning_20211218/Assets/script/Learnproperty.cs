using UnityEngine;

/// <summary>
/// 學習屬性 property
/// </summary>
public class Learnproperty : MonoBehaviour
{
    //屬性語法
    //修飾詞 資料屬性 屬性名稱 {存取子}
    //快速完成 prop + tab*2
    //get 取得 set 存放
    public int MyProperty { get; set; }

    public string passwordfield;
   
    
    //唯讀屬性 去set
    //passwordproperty = " 1234567"; // 有誤 唯讀屬性不能指定 
    //唯讀屬性予值語法 get => "值"
    // => lambda
    public string passwordproperty { get => "666"; }

private void Start()
    {
        //存放屬性 get
        MyProperty = 1;
        //取得屬性 set
        print("等級:" + MyProperty);

        //存取欄位
        passwordfield =" 1234567";
        print("取得欄位密碼:" + passwordfield);

        //存取唯讀屬性 
        print("取得欄位密碼:" + passwordproperty);
    }
}

