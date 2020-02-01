using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
	public SceneTransitionScript transition;
	public GameObject main;
	public GameObject settings;
	public Slider music;
	public Slider sfx;

	public void ToggleMainMenu()
	{
		main.SetActive(true);
		settings.SetActive(false);
	}

	public void ToggleSettingsMenu()
	{
		settings.SetActive(true);
		main.SetActive(false);
	}

	public void StartGame()
	{
		transition.GoFade();
	}

	public void QuitGame()
	{
		Application.Quit();
	}

	public void SetSliderValues(SetAudioLevels audioScript)
	{
		music.value = audioScript.GetMusicLevel();
		sfx.value = audioScript.GetSfxLevel();
	}

}
