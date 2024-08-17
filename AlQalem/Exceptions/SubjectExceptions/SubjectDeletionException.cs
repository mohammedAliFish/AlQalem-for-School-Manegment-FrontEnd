namespace AlQalem.Exceptions.SubjectExceptions
{
    public class SubjectDeletionException : Exception
    {
        public SubjectDeletionException(string message= "لا يمكن حذف المادة لأنها مرتبطة بفصول أو درجات") :base(message) { }
    }
}
