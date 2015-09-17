using UnityEngine;
using System.Collections;

public class Weapons : MonoBehaviour {

	[SerializeField]private float forca;

	private HpMpSp barPlayer;
	// Use this for initialization
	void Start () {
		barPlayer = FindObjectOfType (typeof(HpMpSp))as HpMpSp;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider outro){
		if (outro.gameObject.tag == "Player") {
			barPlayer.PerdeHp(forca);
		}
	}
}
