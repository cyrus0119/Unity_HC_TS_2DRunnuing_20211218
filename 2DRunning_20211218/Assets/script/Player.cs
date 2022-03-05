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

    //�ݩʭ��O debug�Ҧ� �i�ݨp�H���
    private Rigidbody2D rig;
    [Header("���D�̤j�q��"), Range(0, 5)]
    public int countjumpmax = 2;
    public int countjump;

    //�s��Transform���Ĥ@�ؤ覡
    //public Transform traPlayer;

    [Header("�ˬd�a�O�첾")]
    public Vector3 v3GroudOffset;
    [Header("�ˬd�a�O�ؤo")]
    public Vector3 v3GroudSize = Vector3.one;
    [Header("�a�O�ϼh")]
    public LayerMask layerGround;

    private Animator ani;

    [Header("�Ʀ����")]
    public KeyCode keySlide = KeyCode.DownArrow;

    private CapsuleCollider2D cc2d;

    #endregion



    #region �ƥ�


    private void OnDrawGizmos()
    {
        //�M�w�ϥܨƥ�
        Gizmos.color = new Color(1, 0, 0.5f, 0.5f);
        //ø�s�ϥ�
        //�ϥ� ø�s����(�����I �ؤo)
        Gizmos.DrawCube(transform.position + v3GroudOffset, v3GroudSize);
    }
    private void Start()
    {
        //GetComponent<>(); <>�s���x��,�Ҧ�����
        //���o���w����
        rig = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
        cc2d = GetComponent<CapsuleCollider2D>();

    }

    private void Update()
    {
        Run();
        Jomp();
        Slide();
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
        if (InputJump && countjump > 0)
        {
            rig.AddForce(new Vector2(0, jump));
            countjump--;

            ani.SetTrigger(parameterJump);

        }

        Collider2D hit = Physics2D.OverlapBox(transform.position + v3GroudOffset, v3GroudSize, 0, layerGround);


        if (hit && rig.velocity.y < 0)
        {
            countjump = countjumpmax;
        }

    }

    /// <summary>
    ///�Ʀ�
    /// </summary> 
    private void Slide()
    {
        if (Input.GetKey(keySlide))
        {
            ani.SetBool(parameterSlide, true);
        }
        else
        {
            ani.SetBool(parameterSlide, false);
        }
    }


    #endregion
}
