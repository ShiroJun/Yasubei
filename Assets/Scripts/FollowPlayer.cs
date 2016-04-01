using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour
{
	public float left;
	public float right;
	public Transform target;    // ターゲットへの参照

	void Start ()
	{
	}

	void Update ()
	{

		transform.position = new Vector3(target.position.x, 10,-2);
		if(transform.position.x < left){
			transform.position = new Vector3(left, 10, -2);
		}

		if(transform.position.x >= right){
			transform.position = new Vector3(right, 10, -2);
		}
	}
}