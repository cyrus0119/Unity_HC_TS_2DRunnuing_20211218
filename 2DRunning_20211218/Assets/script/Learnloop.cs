using UnityEditor;
using UnityEngine;
/// <summary>
/// �j��
/// 1.while
/// 2.do 
/// 3.for
/// 4.foreach
/// </summary>
public class Learnloop : MonoBehaviour
{
    //�j��@��
    //�B�z���Ƶ{��
    private void Start()
    {
        //��X5�����o �D�j��
        /*
        print("���o");
        print("���o");
        print("���o");
        print("���o");
        print("���o");
        */

        // while �j��y�k�P if �ۦP
        // if (���L��) {�{���϶�};
        // while (���L��) {�{���϶�};
        //�L���j��
        /*
        while(true)
        {
            print(�j��while);
        }
        */
        int count = 0;
        while (count<5)
        {
            print("���o");
            count++;
        }

        //for�j��(��l��; ���L��; �j�鵲���|����{��)
        for (int i = 0; i < 5; i++)
        {
            print("���o" + i );
        }
        //��X�Ʀr0-100 �H5���W
        for (int i = 0; i < 101; i+=5)
        {
            print("��X�Ʀr:" + i);
        }
    }

}
