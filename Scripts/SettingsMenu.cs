using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.Audio;
using System.Collections.Generic;
using System.Linq;

public class SettingsMenu : MonoBehaviour
{
    
    public AudioMixer audioMixer;

    public Dropdown resolutionDropDown;
    Resolution [] resolutions;

    public void Start()
    {
        resolutions = Screen.resolutions.Select(resolution => new Resolution { width = resolution.width, height = resolution.height, }).Distinct().ToArray();
        resolutionDropDown.ClearOptions();

        List<string> options = new List<string>();

        int currentReslutionIndex = 0;


        for(int i =0; i< resolutions.Length; i++)
        {
            string option = resolutions[i].width + "x" + resolutions[i].height;
            options.Add(option);

            if(resolutions[i].width == Screen.width && resolutions[i].height == Screen.height )
            {
                currentReslutionIndex = i ;
            }
        }

        resolutionDropDown.AddOptions(options);
        resolutionDropDown.value = currentReslutionIndex;
        resolutionDropDown.RefreshShownValue(); //permet que la valeur affichée correspode à la valeur utilisée

        Screen.fullScreen = true;
    }

    public void setVolume (float volume)
    {
    audioMixer.SetFloat("volume", volume);
    }    

    public void SetFullScreen(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
    }

    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);

    }

}
