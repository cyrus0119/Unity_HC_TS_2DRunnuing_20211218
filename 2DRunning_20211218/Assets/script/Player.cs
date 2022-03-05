using UnityEngine;

public class Player : MonoBehaviour
{
    #region ���

    [Header("�]�B�t��"), Range(0, 500)]
    public float speed = 1.5f;
    [Header("���D����"), Range(0, 5000)]
    public float jump = 500;
    [Tooltip("�x�s����O�_�b�Ʀ�")]
    public bool isSlide;
    [Tooltip("�x�s����O�_���`")]
    public bool isDead;

    public string parameterJump = "Ĳ�o���D";
    public string parameterSlide = "Ĳ�o�Ʀ�";
    public string parameterDead = "Ĳ�o���`";

    [Tooltip("���D����")]
    public KeyCode keyjump = KeyCode.Space;
    #endregion
    //�ݩʭ��O debug�Ҧ� �i�ݨp�H���
    private Rigidbody2D rig;
    [Header("���D�̤j�q��"), Range(0, 5)]
    public int countjumpmax = 2;
    public int countjump;

    //�s��Transform���Ĥ@�ؤ覡
    //public Transform traPlayer;

    #region �ƥ�

    private void Start()
    {
        //GetComponent<>(); <>�s���x��,�Ҧ�����
        //���o�Ҧ�����
        rig = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Run();
        Jomp(); 
    }
    #endregion

    #region ��k
    /// <summary>
    /// �]�B
    /// </summary>
    private void Run()
    {
        //�s��Transform���Ĥ@�ؤ覡
        //���a�ܧ�.�첾(X,Y,Z);
        // Time.deltaTime �@�V���ɶ�
        //traPlayer.Translate(speed * Time.deltaTime,0,0);

        //�s��Transform���ĤG�ؤ覡
        //��n���Transform �P������P�@���h
        //transform.�����W��
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }

    /// <summary>
    ///���D
    /// </summary>   
    private void Jomp()
    {
        bool InputJump = Input.GetKeyDown(KeyCode.Space);

        //�p�G ���U���D �åB ���D�q��>0 �N ���W�� 
        if (InputJump)
        {
            rig.AddForce(new Vector2(0,jump));
            countjump--;
        }
    }



    #endregion
}
