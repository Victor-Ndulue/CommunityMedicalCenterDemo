namespace CMCDemo_WebApi.Exceptions
{
    public class IdParameterBadRequestException : Exception
    {
        protected IdParameterBadRequestException():base("Parameter Id is null") 
        {
        }
    }
}
