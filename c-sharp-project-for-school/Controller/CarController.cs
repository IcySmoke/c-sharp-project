using c_sharp_project_for_school.Entity;

public class CarController
{
    private List<Car> cars;
    private CarRepository carRepository;

    public CarController()
    {
        carRepository = new CarRepository();
        cars = carRepository.Load();
    }

}