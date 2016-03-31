using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour
{
	public Transform target;    // ターゲットへの参照
	private Vector3 offset;     // 相対座標

	void Start ()
	{
	}

	void Update ()
	{
		Vector3 pos = transform.position;
		pos.x = target.position.x;
		transform.position = pos;
	}
}