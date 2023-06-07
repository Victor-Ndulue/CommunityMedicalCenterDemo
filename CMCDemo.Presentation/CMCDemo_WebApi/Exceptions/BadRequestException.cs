namespace CMCDemo_WebApi.Exceptions
{
    public abstract class BadRequestException:Exception
    {
        protected BadRequestException(string Message):base(Message) { }
    }
}
