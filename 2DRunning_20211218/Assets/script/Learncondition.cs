using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;
/// <summary>
/// �ǲߧP�_��
/// 1. if
/// 2. switch
/// </summary>
public class Learncondition : MonoBehaviour
{
    public bool faskey = true ;
    public int combo = 0;
    public string weapon;

    // �C�| enum (�U�Ԧ����)
    // 1. �w�q�C�|
    public enum Season
        {
            spring, summer, fall, winter
        }
    // 2. ��@�C�|
    public Season season;

    private void Start()
    {
        #region if �P�_��
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
        #endregion

        //switch �y�k
        //switch �P�_�����
        //{
        //  case ��1:
        //      �{�����e;
        //      �_�};
        //  case ��2:
        //      �{�����e;
        //      �_�};
        //  default:
        //      �{�����e;
        //      �_�};
        //}

        switch (weapon)
        {
          case "���C":
              print("akt 10");
              break;
            case "����C":
                print("akt 30");
                break;
            case "��C":
                print("akt 20");
                break;
            default:
                print("�o���O�Z��");
                break;
        }
    }

    private void Update()
    {
        #region if �P�_��2  
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
        #endregion
    }

}
