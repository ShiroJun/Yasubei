using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MiniGameSettingFree : NinjaCounts
{

    public Text miniGameTimeText;
    public Text miniGameCountDownText;
    public Text ninjaScore;
    public Text timeScore;
    public Text ninjaHighScore;
    public Text timeHighScore;
    //public GameObject stone;
    //生まれてくる敵プレハブ
    public GameObject enemyPrefab;
    //敵を格納
    GameObject[] existEnemys;
    //アクティブ最大数
    public int maxEnemy = 50;
    public float time2 = 0;
    public bool start = true;
    // Use this for initialization
    void Start()
    {
        ninjaCount = 0;
        CountDown3();
        //配列確保
        existEnemys = new GameObject[maxEnemy];
        //周期的に実行したい場合はコルーチン
        StartCoroutine(Exec());

    }

    void Update()
    {
        if (start == false)
        {
            time2 += Time.deltaTime;
            miniGameTimeText.text = "時間：" + time2.ToString("0.0");
        }
    }

    //敵を作成する
    IEnumerator Exec()
    {
        while (true)
        {
            //time -= Time.deltaTime;


            for (int i = 0; i < (time2 / 10); i++)
            {
                Generate();
                if (i == 9)
                {
                    break;
                }
            }
            Debug.Log(time2);

            yield return new WaitForSeconds(5.0f);
        }
    }

    void Generate()
    {
        for (int enemyCount = 0; enemyCount < existEnemys.Length; ++enemyCount)
        {
            if (existEnemys[enemyCount] == null)
            {
                int pattern = UnityEngine.Random.Range(0, 4);
                float x = Random.Range(0, 17);
                float z = Random.Range(0, 12);
                //敵を作成する
                switch (pattern)
                {
                    case 0:
                        existEnemys[enemyCount] = Instantiate(enemyPrefab, new Vector3(x, 1f, 0), transform.rotation) as GameObject;
                        break;
                    case 1:
                        existEnemys[enemyCount] = Instantiate(enemyPrefab, new Vector3(x, 1f, 11), transform.rotation) as GameObject;
                        break;
                    case 2:
                        existEnemys[enemyCount] = Instantiate(enemyPrefab, new Vector3(0, 1f, z), transform.rotation) as GameObject;
                        break;
                    case 3:
                        existEnemys[enemyCount] = Instantiate(enemyPrefab, new Vector3(16, 1f, z), transform.rotation) as GameObject;
                        break;
                }
                return;
            }
        }
    }

    void CountDown3()
    {
        miniGameCountDownText.text = "参";
        Invoke("CountDown2", 1f);
    }
    void CountDown2()
    {
        miniGameCountDownText.text = "弐";
        Invoke("CountDown1", 1f);
    }
    void CountDown1()
    {
        miniGameCountDownText.text = "壱";
        Invoke("CountDown0", 1f);
    }
    void CountDown0()
    {
        miniGameCountDownText.text = "始め！";
        Invoke("CountDownGo", 1f);
    }
    void CountDownGo()
    {
        start = false;

    }
}
