using UnityEngine;

/// <summary>
/// �ǲ��ݩ� property
/// </summary>
public class Learnproperty : MonoBehaviour
{
    //�ݩʻy�k
    //�׹��� ����ݩ� �ݩʦW�� {�s���l}
    //�ֳt���� prop + tab*2
    //get ���o set �s��
    public int MyProperty { get; set; }

    public string passwordfield;
   
    
    //��Ū�ݩ� �hset
    //passwordproperty = " 1234567"; // ���~ ��Ū�ݩʤ�����w 
    //��Ū�ݩʤ��Ȼy�k get => "��"
    // => lambda
    public string passwordproperty { get => "666"; }

private void Start()
    {
        //�s���ݩ� get
        MyProperty = 1;
        //���o�ݩ� set
        print("����:" + MyProperty);

        //�s�����
        passwordfield =" 1234567";
        print("���o���K�X:" + passwordfield);

        //�s����Ū�ݩ� 
        print("���o���K�X:" + passwordproperty);
    }
}

