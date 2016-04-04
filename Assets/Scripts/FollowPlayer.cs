using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour
{
	public float left;
	public float right;
	public float up;
	public float down;
	public Transform target;    // ターゲットへの参照

	void Start ()
	{
	}

	void Update ()
	{

		transform.position = new Vector3(target.position.x, 10,target.position.z);
		if(transform.position.x < left){
			transform.position = new Vector3(left, 10, target.position.z);
		}

		if(transform.position.x >= right){
			transform.position = new Vector3(right, 10, target.position.z);
		}
		if(transform.position.x < up){
			transform.position = new Vector3(target.position.x, 10, up);
		}
		if(transform.position.z >= down){
			transform.position = new Vector3(target.position.x, 10, down);
		}


	}
}