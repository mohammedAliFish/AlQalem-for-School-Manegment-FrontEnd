namespace AlQalem.Exceptions.SchoolExceptions
{
    public class LogoUploadException : Exception
    {
        public LogoUploadException(string message = "حدث خطأ أثناء رفع الشعار") : base(message) { }
    }
}
