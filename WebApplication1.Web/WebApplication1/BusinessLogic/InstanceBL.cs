namespace WebApplication1.BusinessLogic
{
    internal class InstanceBL
    {
        internal ISession GetSessionBL()
        {
            return new SessionBL();
        }
    }
}