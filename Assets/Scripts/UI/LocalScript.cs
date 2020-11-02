using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using TMPro;
using Photon.Realtime;
using Hashtable = ExitGames.Client.Photon.Hashtable;
using Shapes2D;

public class LocalScript : MonoBehaviourPunCallbacks
{
	[Header("Debug")]
	private TMP_Text text;

	void Awake()
	{
		text = GetComponent<TMP_Text>();
	}

	public override void OnPlayerPropertiesUpdate(Player targetPlayer, Hashtable changedProps)
	{
		PhotonNetwork.LocalPlayer.CustomProperties.TryGetValue("score", out object score);
		text.text = ((int)(score ?? 0)).ToString();
	}
}
