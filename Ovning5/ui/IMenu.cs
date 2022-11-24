using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning5.ui
{
    public interface IMenu
    {
        public void print();
        public IMenu interact(IUI ui, IHandler handler);
    }
}
