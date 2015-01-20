using UnityEngine;
using System.Collections;

public class EnemyRotateTurret : BaseRotateTurret {
	public Transform player;

	override protected void Start()
	{

		base.Start();
		targetPos = player.position;
	}

	// Update is called once per frame
	override protected void Update () {

		base.Update();
	
	}
}
