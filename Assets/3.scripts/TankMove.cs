using UnityEngine;
using System.Collections;

public class TankMove : MonoBehaviour {

	public float mSpeed = 1;//���ʳt��
	public float rSpeed = 1;//����t��
	public float mDevelop = 1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		var h = Input.GetAxis("Horizontal");//��������b�V����
		var v = Input.GetAxis("Vertical");//��������b�V����
		
		transform.Translate(0,0,mSpeed * -v);//�ھڤ����b�V����ӫe�i�Ϋ�h
		transform.Rotate(0,rSpeed * h,0);//�ھګ����b�V����ӱ���
	}
}
