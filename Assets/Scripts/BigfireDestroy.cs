using UnityEngine;
using System.Collections;

public class BigfireDestroy : MonoBehaviour {

    void OnAnimationFinish()
    {
        Destroy(gameObject);
    }
}
