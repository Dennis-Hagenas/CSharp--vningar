namespace Ovning5.ui
{
    public interface IMenu
    {
        public void print();
        public IMenu interact(IUI ui, IHandler handler);
    }
}
