using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class MiniGamePlayerMoveFree : GameController {

    public float speed;
    GameObject gameController;
    private float SPPOW;
    public bool notPass;
    private Animator anim;
    public bool damage;
    public GameObject result;
    float y;
    float highTimeFree;
    int highNinjaFree;

    void Start()
    {
        highTimeFree = PlayerPrefs.GetFloat("HighScoreTimeFree", 0);
        highNinjaFree = PlayerPrefs.GetInt("HighScoreNinjaFree", 0);
        this.tag = "Player";
        //Invoke("Destroy", 100);
        anim = GetComponent<Animator>();
        damage = false;
        y = transform.rotation.y;
        SPPOW = speed + (SpPow * 0.01f);

    }
    //private float y = 90;
    // Update is called once per frame
    void Update()
    {
        gameController = GameObject.Find("GameController");


    }
    void FixedUpdate()
    {
        PlayerControl();
        PlayerControl2();
    }
    void PlayerControl()
    {
        float h = CrossPlatformInputManager.GetAxisRaw("Horizontal");
        float v = CrossPlatformInputManager.GetAxisRaw("Vertical");
        //Debug.Log(h);
        if (notPass == true && damage == false)
        {
            if (v > 0.4f)
            {
                transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
                transform.position += transform.forward * SPPOW;
                anim.SetBool("Run", true);
                //transform.position += transform.forward * SPPOW;
                //anim.SetBool("Run",true);
            }
            else
            {
                anim.SetBool("Run", false);
            }

            if (h > 0.4f)
            {
                //y += 2f;
                //transform.rotation = Quaternion.Euler(transform.rotation.x, y, transform.rotation.z);
                transform.rotation = Quaternion.Euler(new Vector3(0, 90, 0));
                transform.position += transform.forward * SPPOW;
                anim.SetBool("Run", true);
            }
            if (h < -0.4f)
            {
                //y -= 2f;
                //transform.rotation = Quaternion.Euler(transform.rotation.x, y, transform.rotation.z);
                transform.rotation = Quaternion.Euler(new Vector3(0, 270, 0));
                transform.position += transform.forward * SPPOW;
                anim.SetBool("Run", true);
            }
            if (v < -0.4f)
            {
                transform.rotation = Quaternion.Euler(new Vector3(0, 180, 0));
                transform.position += transform.forward * SPPOW;
                anim.SetBool("Run", true);
            }
        }
    }
    void PlayerControl2()
    {
        if (notPass == true && damage == false)
        {
            if (Input.GetKey("up"))
            {
                transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
                transform.position += transform.forward * SPPOW;
                anim.SetBool("Run", true);
                //transform.position += transform.forward * SPPOW;
                //anim.SetBool("Run",true);
            }
            else
            {
                anim.SetBool("Run", false);
            }

            if (Input.GetKey("right"))
            {
                //y += 2f;
                //transform.rotation = Quaternion.Euler(transform.rotation.x, y, transform.rotation.z);
                transform.rotation = Quaternion.Euler(new Vector3(0, 90, 0));
                transform.position += transform.forward * SPPOW;
                anim.SetBool("Run", true);
            }
            if (Input.GetKey("left"))
            {
                //y -= 2f;
                //transform.rotation = Quaternion.Euler(transform.rotation.x, y, transform.rotation.z);
                transform.rotation = Quaternion.Euler(new Vector3(0, 270, 0));
                transform.position += transform.forward * SPPOW;
                anim.SetBool("Run", true);
            }
            if (Input.GetKey("down"))
            {
                transform.rotation = Quaternion.Euler(new Vector3(0, 180, 0));
                transform.position += transform.forward * SPPOW;
                anim.SetBool("Run", true);
            }
        }
    }
    void OnTriggerEnter(Collider hit)
    {
        if (hit.tag == "Enemy" && damage == false)
        {
            damage = true;
            this.tag = "Untagged";
            anim.SetBool("Death", true);
            //Invoke("GameOverFlag", 2f);
            //PlayerLife.life--;
            Result();

        }
        if (hit.tag == "Bakufu" && damage == false)
        {
            damage = true;
            this.tag = "Untagged";
            anim.SetBool("Death", true);
            //Invoke("GameOverFlag", 2f);
            //PlayerLife.life--;
            Result();
        }
        if (hit.CompareTag("Item"))
        {
            if (hit.name.IndexOf("ExPow") != -1)
            {
                if (ExPow < 5)
                {
                    gameController = GameObject.Find("GameController");
                    ExPow += 1;
                }
            }
            else if (hit.name.IndexOf("SpPow") != -1)
            {
                if (SpPow < 5)
                {
                    gameController = GameObject.Find("GameController");
                    SpPow += 1;
                }
            }
            else if (hit.name.IndexOf("Invent") != -1)
            {
                if (Invent < 5)
                {
                    gameController = GameObject.Find("GameController");
                    Invent += 1;
                }
            }
        }
        else if (hit.CompareTag("NotPass"))
        {
            notPass = false;
        }
    }
    void OnTriggerExit(Collider hit)
    {
        if (hit.CompareTag("NotPass"))
        {
            notPass = true;
        }
    }
    void Result()
    {
        GameObject goMGS = GameObject.Find("MiniGameSettingFree");
        MiniGameSettingFree miniGameSetting = goMGS.GetComponent<MiniGameSettingFree>();
        miniGameSetting.start = true;
        miniGameSetting.timeScore.text = "耐えた時間：" + miniGameSetting.time2.ToString("0.00");
        miniGameSetting.ninjaScore.text = "忍者撃退数：" + (NinjaCounts.ninjaCount * -1);
        if (miniGameSetting.time2 > highTimeFree)
        {
            PlayerPrefs.SetFloat("HighScoreTimeFree", miniGameSetting.time2);
            highTimeFree = miniGameSetting.time2;
        }
        if ((NinjaCounts.ninjaCount * -1) > highNinjaFree)
        {
            PlayerPrefs.SetInt("HighScoreTimeFree", (NinjaCounts.ninjaCount * -1));
            highNinjaFree = (NinjaCounts.ninjaCount * -1);
        }
        miniGameSetting.timeHighScore.text = "耐えた時間：" + highTimeFree.ToString("0.00");
        miniGameSetting.ninjaHighScore.text = "忍者撃退数：" + highNinjaFree;
        result.SetActive(true);
    }
}
