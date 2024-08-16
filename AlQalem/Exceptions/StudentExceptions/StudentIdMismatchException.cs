namespace AlQalem.Exceptions.StudentExceptions
{
    public class StudentIdMismatchException : Exception
    {
        public StudentIdMismatchException(string message= "لا يتطابق معرف الطالب") : base(message) { }
    }
}
