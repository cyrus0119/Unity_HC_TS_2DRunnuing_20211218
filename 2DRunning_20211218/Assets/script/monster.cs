using UnityEngine;      //引用 unity引擎空間
//檔案類別 名稱
public class monster : MonoBehaviour
{
    #region 欄位  Fidle
    //欄位語法
    //修飾詞 資料類型 欄位名稱 結尾
    //整數    int
    //浮點數  float
    //字串    string
    //布林    bool
    //修飾詞 私人(預設)OR公開
    //私人 不顯示 privant
    //公開 顯示 public 
    public int Hp = 100;
    public float Atk = 100f;        //f or F 做結尾
    public string Heam = "砲灰";    //""包覆
    public bool FitOut = true;     //true or false

    //顏色color
    public Color colorA;
    public Color colorB = new Color(0.3f, 0, 0.4f, 0.9f); //新顏色RGBA
    #endregion
}
