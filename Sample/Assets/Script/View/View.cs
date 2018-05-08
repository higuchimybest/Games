using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class View : MonoBehaviour {
	
	[SerializeField]
	public delegate void OnSumButtonChildClicked(PointerEventData data); // delegate 型の宣言
	[SerializeField]
	// 「加算」ボタンが押された時のイベントリスナー
	public OnSumButtonChildClicked OnSumButtonClickedListener;


	// 「＋」ボタンが押された時に呼ばれるメソッド
	public void OnSumButtonClicked(PointerEventData data)
	{
		if (OnSumButtonClickedListener != null)
		{
			OnSumButtonClickedListener(data);
		}
	}
}
