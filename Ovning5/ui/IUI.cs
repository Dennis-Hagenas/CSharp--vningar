using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning5.ui
{
    public interface IUI
    {
        int askForIntInput(string prompt);
        string askForStringInput(string prompt);
    }
}
