namespace CMCDemo_WebApi.Exceptions
{
    public class ProffesionalStaffNotFoundException : NotFoundException
    {
        public ProffesionalStaffNotFoundException(string Name) :
            base($"The staff with name {Name} does not exist")
        {
        }
    }
}
