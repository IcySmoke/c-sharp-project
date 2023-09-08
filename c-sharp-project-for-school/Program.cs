using c_sharp_project_for_school.Entity;

namespace c_sharp_project_for_school
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            CarRepository carRepository = new CarRepository();

            // Create a new test car
            Car testCar = new Car(1, "TEST123", "TestBrand", "TestType", 10000);

            // Add the test car to the controller
            carRepository.Save(testCar);
        }
    }
}