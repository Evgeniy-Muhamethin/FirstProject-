using UnityEngine;
using TMPro;

public class CanvasPlayerMain : MonoBehaviour
{
	[SerializeField]
	private TMP_Text _text;

    private HealthPlayer _healthPlayer;

	//TODO не считывает новые и измененные данные с —“–” “”–џ ƒјЌЌџ’ (HealthPlayer)
	private void Update()
	{
		string printHealth = $"{_healthPlayer.health}";
		_text.text = printHealth;
	}

}
