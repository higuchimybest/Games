﻿using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;
using UnityEngine.EventSystems;

/*
 * 
 * Some code is borrowed from [Rx.NET](https://rx.codeplex.com/) and [mono/mcs](https://github.com/mono/mono).
 *
 */
public class Presenter : MonoBehaviour {
	// View
	[SerializeField]
	private View _view;

	// Model
	[SerializeField]
	private Model _model;

	// オブジェクト生成時に呼び出す
	public void Awake()
	{
		// ビューのオブジェクトを作成
		_view = new View ();

		// 各種ビューのコールバックを設定	
		SetEvents();
	}

	// Viewのイベントの設定を行う
	private void SetEvents()
	{
/*
        var hoge = GameObject.Find("sum");
		EventTrigger trigger = hoge.GetComponent<EventTrigger>();
		EventTrigger.Entry entry = new EventTrigger.Entry();
		entry.eventID = EventTriggerType.PointerDown;
		entry.callback.AddListener(( data ) => { _view.OnSumButtonClicked( (PointerEventData)data ); });
		trigger.triggers.Add(entry);

		_view.OnSumButtonClickedListener = OnSumButtonChildClicked;
*/
	}

	void Start () {

		//10秒毎に花火を上げる
		// ※開発用に2秒にした
		Observable.Interval(TimeSpan.FromMilliseconds(1000*2)).Subscribe(l => {
				
			_view.ViewFireworks(22);

		}).AddTo(this);
	}

	// 「＋」ボタンが押された時に呼ばれるメソッド
	public void OnSumButtonChildClicked(PointerEventData data)
	{
		Debug.Log ("Click");
	}
}
