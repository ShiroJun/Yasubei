using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour
{
	public float left;
	public float right;
	public float up;
	public float down;
	public float angle;
	public Transform target;    // ターゲットへの参照

	void Start ()
	{
	}

	void Update ()
	{
		transform.position = new Vector3(target.position.x, 10,target.position.z -angle);

		if(transform.position.x < left){
			if (transform.position.x < left && transform.position.z >= up) {
				transform.position = new Vector3(left, 10, up-0.01f);
				//Debug.Log ("tes");
			}
			else if (transform.position.x < left && transform.position.z < down) {
				transform.position = new Vector3 (left, 10, down);
			} 
			else {
				transform.position = new Vector3(left, 10, target.position.z -angle);
			}

		}

		if(transform.position.x >= right){
			if(transform.position.x >= right && transform.position.z >= up){
				transform.position = new Vector3(right, 10, up-0.01f);

			}
			else if (transform.position.x >= right && transform.position.z < down) {
				transform.position = new Vector3 (right, 10, down);
			} 
			else {
				transform.position = new Vector3(right, 10, target.position.z -angle);
			}

		}
		else if(transform.position.z >= up){
			transform.position = new Vector3(target.position.x, 10, up);
		}
		else if(transform.position.z < down){
			transform.position = new Vector3(target.position.x, 10, down);
		}


	}
}