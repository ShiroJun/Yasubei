using UnityEngine;
using System.Collections;

public class DontDestroy : MonoBehaviour {

    private GameObject sound;

    void Awake () {

        DontDestroyOnLoad(this);
    }

}
