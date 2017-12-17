using System.Collections.Generic;
using UnityEngine;

public class ResearchPanelController : MonoBehaviour
{
    public GameObject researchPrefab;
    private List<Research> _researches;
    private MainResourceController _mainController;

    public delegate void OnResearchFinished();
    public event OnResearchFinished onFinished;

    void Awake()
    {
        _researches = new List<Research>();
        _researches.Add(new Research("More Bays", "You can build more bays", AllResearches.More_Bays, 5));
        _researches.Add(new Research("Machineguns", "You can build machineguns", AllResearches.Machinegun, 5));
        _researches.Add(new Research("Ammo", "Learn to make ammo", AllResearches.Ammo, 5));
        _researches.Add(new Research("Fuel", "Learn to make fuel for engines", AllResearches.Fuel, 2));
        _researches.Add(new Research("Rockets", "used for weopens", AllResearches.Rockets, 2));
        _researches.Add(new Research("Search Droid", "Droid used for mining ", AllResearches.SearchDroid, 2));
        _researches.Add(new Research("Repair Droid", "Droid used for repairing the ship", AllResearches.RepairDroid, 2));
    }

    void Start()
    {
        GenerateResearches();
    }

    public void SetMainController(MainResourceController controller)
    {
        _mainController = controller;
    }

    public MainResourceController GetMainController()
    {
        return _mainController;
    }

    private void GenerateResearches()
    {
        for (int i = 0; i < _researches.Count; i++)
        {
            GameObject newResearchGameObject = Instantiate(researchPrefab);
            newResearchGameObject.transform.SetParent(gameObject.transform);
            newResearchGameObject.transform.localScale = new Vector3(1, 1, 1);

            ResearchController researchController = newResearchGameObject.GetComponent<ResearchController>();
            researchController.GetResearchModel().SetResearch(_researches[i]);
            researchController.GetResearchModel().SetPanelController(this);
        }
    }

    public bool IsResearchLearned(AllResearches research)
    {
        for (int i = 0; i < _researches.Count; i++)
        {
            if (_researches[i].GetResearch() == research)
            {
                if (_researches[i].IsLearned())
                {
                    return true;
                }
                return false;
            }
        }
        return false;
    }

    public void OnResearchFinishedEvent()
    {
        if (onFinished != null)
            onFinished();
    }
}