namespace AlQalem.Exceptions.SchoolExceptions
{
    public class InvalidSchoolDataException : Exception
    {
        public InvalidSchoolDataException(string message= "بيانات المدرسة غير صالحة") : base(message)
        {
        }
    }
}
