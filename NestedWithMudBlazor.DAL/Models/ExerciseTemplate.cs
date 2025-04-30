namespace NestedWithMudBlazor.DAL.Models
{
    public class ExerciseTemplate
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int[] Types { get; set; } = [];
    }
}
