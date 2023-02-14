using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Playables;

public class MenuController : MonoBehaviour
{
    [Header("MenuCanvas")]
    [SerializeField]
    private GameObject menuPanel;
    
    [SerializeField]
    private GameObject firstElementOfMenu;


    [Header("Display when start pressed")]
    [SerializeField]
    private List<GameObject> startItems;
    
    [Header("Start animation")]
    [SerializeField]
    private PlayableDirector startSequence;
    // Start is called before the first frame update
    void Start()
    {
        menuPanel.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private IEnumerator SelectFirstChoice()
    {
        EventSystem.current.SetSelectedGameObject(null);
        yield return new WaitForEndOfFrame();
        EventSystem.current.SetSelectedGameObject(firstElementOfMenu);
    }
    private IEnumerator ExitMenu()
    {
        yield return new WaitForSeconds(0.2f);
        

        menuPanel.SetActive(false);
        

    }

    public void StartGame()
    {
        menuPanel.SetActive(false);
        foreach (var item in startItems)
        {
            item.SetActive(true);
        }
        startSequence.Play();
        
    }
}
