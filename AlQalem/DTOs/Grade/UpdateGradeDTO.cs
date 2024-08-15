namespace AlQalem.DTOs.Grade
{
    public class UpdateGradeDTO : CreateGradeDTO
    {
        public required Guid GradeId { get; set; }
    }
}
