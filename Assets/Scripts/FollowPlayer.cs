using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour
{
	public float left;
	public float right;
	public float up;
	public float down;
	public float height;
	public float angle;
	public Transform target;    // ターゲットへの参照

	void Start ()
	{
	}

	void Update ()
	{

		transform.position = new Vector3(target.position.x, height,target.position.z - angle);
		if(transform.position.x < left){
			transform.position = new Vector3(left, height, target.position.z);
		}
		if(transform.position.x >= right){
			transform.position = new Vector3(right, height, target.position.z);
		}
		if(transform.position.z >= up){
			transform.position = new Vector3(target.position.x, height, up);
		}
		if(transform.position.z < down){
			transform.position = new Vector3(target.position.x, height, down);
		}


	}
}