﻿using UnityEngine;
using UnityEngine.UI;

namespace BoM.UI {
	// OnEnableFocusEmptyField
	public class OnEnableFocusEmptyField : MonoBehaviour {
		// The input fields we check for empty text
		public InputField[] fields;

		// OnEnable
		void OnEnable() {
			// Check all fields for empty text
			foreach(var field in fields) {
				if(string.IsNullOrEmpty(field.text)) {
					StartCoroutine(OnEnableFocus.SelectWhenActive(field));
					return;
				}
			}
		}

		// OnDisable
		void OnDisable() {
			StopAllCoroutines();
		}
	}
}