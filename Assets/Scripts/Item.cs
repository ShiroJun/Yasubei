using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour
{
	void OnTriggerEnter (Collider hit)
	{
		//Invoke("Invincible", 1);
		// 接触対象はPlayerタグですか？
		//Debug.Log(hit.name);
		if (hit.CompareTag ("Player")) {
			// このコンポーネントを持つGameObjectを破棄する
			Destroy(gameObject);
		}
		if (hit.CompareTag ("Bakufu")) {
			// このコンポーネントを持つGameObjectを破棄する
			Destroy(gameObject);
		}
	}
}