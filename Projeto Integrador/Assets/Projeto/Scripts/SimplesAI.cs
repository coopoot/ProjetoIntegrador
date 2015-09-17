using UnityEngine;
using System.Collections;

public class SimplesAI : MonoBehaviour {
	
	[SerializeField]private float speed;
	[SerializeField]private float movimentador;
	[SerializeField]private Transform enemyAnimator;



	private Transform player;
	private Animator animator;

	void Start () {
	
		player = GameObject.FindGameObjectWithTag("Player").transform;
		animator = enemyAnimator.GetComponent<Animator> ();
	}

	void Update(){

		controleDistancia();

	}

	void controleDistancia(){

		float distanciaPlayer = Vector3.Distance (transform.position, player.position);
		if (distanciaPlayer <20 && distanciaPlayer>1) {
			seguirPLayer(true);
			animator.SetBool("ataque",true);

		} else {
			movimentador = movimentador + 0.01f * Time.deltaTime;
			movimento ();
			seguirPLayer(false);
		}
	}
	void seguirPLayer(bool seguir){
		if (seguir) {
			Vector3 direcao = (player.position - transform.position).normalized;
			transform.position += direcao * Time.deltaTime * speed; 
			Quaternion olharPlayer = Quaternion.LookRotation (direcao);
			transform.rotation = olharPlayer;
		} else {
			return;
		}
	}
	void movimento(){
		if(movimentador>=0.1f&&movimentador<=0.2f){
			transform.Translate(speed*Time.deltaTime,0,0);
		}
		if(movimentador>=0.21f&&movimentador<=0.3f){
			transform.Translate(0,0,speed*Time.deltaTime);
		}
		if(movimentador>=0.31f&&movimentador<=0.4f){
			transform.Translate(-speed*Time.deltaTime,0,0);
		}
		if(movimentador>=0.41f&&movimentador<=0.5f){
			transform.Translate(0,0,-speed*Time.deltaTime);
		}
		if(movimentador>0.5f){
			movimentador=0;
		}
	}

}
