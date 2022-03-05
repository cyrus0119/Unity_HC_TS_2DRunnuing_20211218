using UnityEngine;

public class Player : MonoBehaviour
{
    #region 欄位

    [Header("跑步速度"), Range(0, 500)]
    public float speed = 1.5f;
    [Header("跳躍高度"), Range(0, 5000)]
    public float jump = 500;
    [Tooltip("儲存角色是否在滑行")]
    public bool isSlide;
    [Tooltip("儲存角色是否死亡")]
    public bool isDead;

    public string parameterJump = "觸發跳躍";
    public string parameterSlide = "觸發滑行";
    public string parameterDead = "觸發死亡";

    [Tooltip("跳躍按鍵")]
    public KeyCode keyjump = KeyCode.Space;

    //屬性面板 debug模式 可看私人資料
    private Rigidbody2D rig;
    [Header("跳躍最大段數"), Range(0, 5)]
    public int countjumpmax = 2;
    public int countjump;

    //存取Transform的第一種方式
    //public Transform traPlayer;

    [Header("檢查地板位移")]
    public Vector3 v3GroudOffset;
    [Header("檢查地板尺寸")]
    public Vector3 v3GroudSize = Vector3.one;
    [Header("地板圖層")]
    public LayerMask layerGround;

    private Animator ani;

    [Header("滑行按鍵")]
    public KeyCode keySlide = KeyCode.DownArrow;

    private CapsuleCollider2D cc2d;

    #endregion



    #region 事件


    private void OnDrawGizmos()
    {
        //決定圖示事件
        Gizmos.color = new Color(1, 0, 0.5f, 0.5f);
        //繪製圖示
        //圖示 繪製方體(中心點 尺寸)
        Gizmos.DrawCube(transform.position + v3GroudOffset, v3GroudSize);
    }
    private void Start()
    {
        //GetComponent<>(); <>存取泛型,所有類型
        //取得指定元件
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



    #region 方法
    /// <summary>
    /// 跑步
    /// </summary>
    private void Run()
    {
        //存取Transform的第一種方式
        //玩家變形.位移(X,Y,Z);
        // Time.deltaTime 一幀的時間
        //traPlayer.Translate(speed * Time.deltaTime,0,0);

        //存取Transform的第二種方式
        //當要控制的Transform 與此物件同一階層
        //transform.成員名稱
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }

    /// <summary>
    ///跳躍
    /// </summary>   
    private void Jomp()
    {
        bool InputJump = Input.GetKeyDown(KeyCode.Space);

        //如果 按下跳躍 並且 跳躍段數>0 就 往上跳 
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
    ///滑行
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
