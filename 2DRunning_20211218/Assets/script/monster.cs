using UnityEngine;      //�ޥ� unity�����Ŷ�
//�ɮ����O �W��
public class monster : MonoBehaviour
{
    #region ���  Fidle
    //���y�k
    //�׹��� ������� ���W�� ����
    //���    int
    //�B�I��  float
    //�r��    string
    //���L    bool
    //�׹��� �p�H(�w�])OR���}
    //�p�H ����� privant
    //���} ��� public 
    public int Hp = 100;
    public float Atk = 100f;        //f or F ������
    public string Heam = "����";    //""�]��
    public bool FitOut = true;     //true or false

    //�C��color
    public Color colorA;
    public Color colorB = new Color(0.3f, 0, 0.4f, 0.9f); //�s�C��RGBA
    #endregion
}
