namespace EntityFrameworkOwnedBug
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            using var context = new AppContext();

            var axis = new Axis();

            context.Axes.Add(axis);

            context.SaveChanges();
        }
    }
}
