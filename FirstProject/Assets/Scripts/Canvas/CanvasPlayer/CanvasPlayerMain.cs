using UnityEngine;
using TMPro;

public class CanvasPlayerMain : MonoBehaviour
{
	[SerializeField]
	private TMP_Text _text;

    private HealthPlayer _healthPlayer;

	//TODO �� ��������� ����� � ����������
	//������ � ��������� ������ (HealthPlayer)
	private void Update()
	{
		string printHealth = $"{_healthPlayer.Health}";
		_text.text = printHealth;
	}

}
