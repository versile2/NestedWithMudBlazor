using NestedWithMudBlazor.DAL.Models;

namespace NestedWithMudBlazor.DAL.Repositories
{
    public class ExerciseRepository
    {
        private readonly List<ExerciseType> _typeList = [];
        private readonly List<ExerciseTemplate> _exerciseList = [];
        public ExerciseRepository()
        {
            _typeList = SeedData.GetExerciseTypes();
            _exerciseList = SeedData.GetExercises();
        }

        public List<ExerciseTemplate> GetExercises()
        {
            return _exerciseList;
        }

        public List<ExerciseType> GetExerciseTypes()
        {
            return _typeList;
        }

    }
}
