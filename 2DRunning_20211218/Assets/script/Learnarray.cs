using System.Threading;
using UnityEngine;

/// <summary>
/// �ǲ߰}�C
/// </summary>

public class Learnarray : MonoBehaviour
{
    //�}�C �Ω��x�s�ۦP�������h�����

    //�ϥ�����x�s�h�����
    public int atk1 = 10;
    public int atk2 = 20;
    public int atk3 = 30;

    //�}�C�y�k
    //�������[] �[���A�����}�C
    public int[] atks;

    //�}�C��l��
    //1.���w�}�C���C��Ƽƶq�����w���e
    public float[] speeds = new float [5];

    //2.���w�}�C���e
    public string[] props = { "����", "�Ť�", "���" };
    public Vector3[] positions = { };
    public bool[] complete = { true, true, true };

    private void Start()
    {
        //�s���}�C���
        //1.�s��}�C���
        //�}�C�W��[�s��]��
        //�N�}�C�ĤT����Ƨאּ66
        atks[2] = 66;
        //2.�ϥΰ}�C���~
        //IndexOutOfRange - �s�����s�b
        //atk[3]=99 
    }


}
