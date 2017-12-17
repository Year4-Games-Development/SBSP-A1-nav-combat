using UnityEngine.UI;

public class ManuModel
{

    private ManuController _manuController;
    private MainResourceController _mainController;
    private ResearchPanelController researchPanelController;
    private Manufacture _manufacture;
    private ManuPanelController _manuPanelController;

    private RechargeTimer _timer;
    private ManuView _view;
    private int _numberOfProducts;

    public ManuModel(Text name, Text description, Button button, Text cost)
    {
        _view = new ManuView(name, description, button, cost);
        _timer = new RechargeTimer();
    }

    public void SetManufacture(Manufacture manufacture)
    {
        _manufacture = manufacture;

        _view.SetName(_manufacture.GetName());
        _view.SetDescription(_manufacture.GetDescription());
        _view.SetCost("Cost: " + _manufacture.GetCost());
    }

    public void SetManufactureController(ManuController controller)
    {
        _manuController = controller;
    }

    public ManuView GetManuView()
    {
        return _view;
    }

    public Manufacture GetManufacture()
    {
        return _manufacture;
    }

    public RechargeTimer GetTimer()
    {
        return _timer;
    }
    public ManuController GetManuController()
    {
        return _manuController;
    }

    public void SetMainController(MainResourceController controller)
    {

        _mainController = controller;

    }

    public MainResourceController GetMainController()
    {

        return _mainController;

    }

    public void SetManuPanelController(ManuPanelController controller)
    {
        _manuPanelController = controller;
    }

    public ManuPanelController GetManuPanelController()
    {
        return _manuPanelController;
    }
}