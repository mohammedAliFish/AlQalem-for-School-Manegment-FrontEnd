namespace AlQalem.Exceptions.SubjectExceptions
{
    public class SubjectIdMismatchException : Exception
    {
        public SubjectIdMismatchException(string message= "عدم تطابق معرف المادة") : base(message) { }
    }
}
