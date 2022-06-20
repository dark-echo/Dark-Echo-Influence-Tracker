using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;

namespace DETrackerWPF.ViewModels
{
  public class PopUpMessageViewModel : Screen
  {

    public PopUpMessageViewModel(int Systems)
    {
      NumOfSystems =
        string.Format(
          "There are {0} Systems that have not been updated since configured tick time, these have been copied to the Clipboard", Systems);
    }

    public void ClosePopUp()
    {
      TryCloseAsync();
    }


    private string _numOfSystems;

    public string NumOfSystems
    {
      get { return _numOfSystems; }
      set
      {
        _numOfSystems = value;
        NotifyOfPropertyChange(() => NumOfSystems);
      }
    }

  }
}
