using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HpMpSp : MonoBehaviour {

	//variaveis inspector
	[SerializeField]private Scrollbar healthBar;
	[SerializeField]private Scrollbar manaMpBar;
	[SerializeField]private Scrollbar manaSpBar;
	[SerializeField]private float health,manaMp,manaSp;



	//variaveis local



	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}
	public void PerdeHp(float hp){
		health -= hp;
		healthBar.size = health/100f;
		print (health);
	}
	public void RecarregaHp(float hp){
		health += hp;
		healthBar.size = health/100f;
	}
	void PerdeMp(float mp){
		manaMp -= mp;
		manaMpBar.size = manaMp/100f;
	}
	void RecarregaMp(float mp){
		manaMp += mp;
		manaMpBar.size = manaMp/100f;
	}
	void PerdeSp(float sp){
		manaSp -= sp;
		manaSpBar.size = manaSp/100f;
	}
	void RecarregaSp(float sp){
		manaSp += sp;
		manaSpBar.size = manaSp/100f;
	}


}
