﻿using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Demonics.UI
{
	public class BaseMenu : MonoBehaviour
	{
		[SerializeField] protected Selectable _startingOption = default;


		public void OpenMenuHideCurrent(BaseMenu menu)
		{
			EventSystem.current.SetSelectedGameObject(null);
			gameObject.SetActive(false);
			menu.Show();
		}

		public void OpenMenu(BaseMenu menu)
		{
			menu.gameObject.SetActive(true);
		}

		public void Show()
		{
			gameObject.SetActive(true);
			StartCoroutine(ActivateCoroutine());
		}

		public void Hide()
		{
			EventSystem.current.SetSelectedGameObject(null);
			gameObject.SetActive(false);
		}

		void OnEnable()
		{
			StartCoroutine(ActivateCoroutine());
		}

		IEnumerator ActivateCoroutine()
		{
			yield return null;
			if (_startingOption != null)
			{
				_startingOption.Select();
			}
		}
	}
}