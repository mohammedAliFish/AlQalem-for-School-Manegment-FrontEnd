namespace AlQalem.Exceptions.SubjectExceptions
{
    public class SubjectNotFoundException : Exception
    {
        public SubjectNotFoundException(string message= "المادة المطلوبة غير موجودة") :base(message) { }
    }
}
