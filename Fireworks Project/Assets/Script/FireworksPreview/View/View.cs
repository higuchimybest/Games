using UnityEngine;
using UnityEditor;
using System.Collections;
using UnityEngine.EventSystems;

public class View : MonoBehaviour {
	
	[SerializeField]
	public delegate void OnSumButtonChildClicked(PointerEventData data); // delegate 型の宣言
	[SerializeField]
	// 「加算」ボタンが押された時のイベントリスナー
	public OnSumButtonChildClicked OnSumButtonClickedListener;


	// 花火を表示する
	public void ViewFireworks(int type)
	{
		if (type == 1)
		{
			Transform player = GameObject.Find("Player").transform;

			if (player != null) {
				GameObject mainPlayer = player.Find("MainPlayer").gameObject;

				Vector3 pointList = mainPlayer.transform.position;
				GameObject perefab = (GameObject)Resources.Load ("Prefab/DefaultSeedObject");

				pointList.y += 10;
				pointList.z += 100;
				GameObject newGameObject = Instantiate (perefab, pointList, Quaternion.identity);
				newGameObject.transform.Rotate (new Vector3(-90, 0, 0));
			}
		}
	}

	// 「＋」ボタンが押された時に呼ばれるメソッド
/*	public void OnSumButtonClicked(PointerEventData data)
	{
		if (OnSumButtonClickedListener != null)
		{
			OnSumButtonClickedListener(data);
		}
	}*/
}
