using UnityEditor;
using UnityEngine;
/// <summary>
/// �ǲߧP�_��
/// 1. if
/// 2. switch
/// </summary>
public class Learncondition : MonoBehaviour
{
    public bool faskey = true ;
    public int combo = 0;

    private void Start()
    {
        // if �y�k
        // if (���L��) {�{���϶��B�t��k�B���z��}
        //�ֳt���� if + tab*2
        //���L�ȵ��� true �|����{}�����{��
        //          false ������

        if (true)
        {
            print("if�P�_������");
        }

        //�}���P�_��

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
        //else if �����b if �U�� �S���ƶq����
        //else if (���L��) {�{���϶��B�t��k�B���z��}
        //�s������10�����O�[10
        if (combo == 10) 
        {
            print("�����O�[10");
        }
        //�s������100�����O�[100
        else if (combo == 100)
        {
            print("�����O�[100");
        }
        //�s������500�����O�[500
        else if (combo == 500)
        {
            print("�����O�[500");
        }
    }

}
