using System;

// Класс, представляющий информацию о изменении температуры
class Temperature : EventArgs
{
    public double NewTemperature { get; }
    //получение новой температуры
    public Temperature(double newTemperature)
    {
        NewTemperature = newTemperature;
    }
}

// Класс, представляющий датчик температуры
class TemperatureSensor
{
    private double currentTemperature; //поле для хранения текущей измеренной температуры.
    public event EventHandler<Temperature> TemperatureChanged; //: Событие, которое генерируется при изменении температуры.

    // Свойство для доступа к текущей температуре. При изменении значения генерируется событие TemperatureChanged.
    public double CurrentTemperature 
    {
        get { return currentTemperature; } //получение температуры
        set
        {
            //проверяет, отличается ли новое значение "value" от текущего значения currentTemperature
            if (currentTemperature != value)
            {
                currentTemperature = value;
                OnTemperatureChanged(new Temperature(value));
            }
        }
    }
    // Метод для вызова события TemperatureChanged
    protected virtual void OnTemperatureChanged(Temperature e)
    {
        TemperatureChanged?.Invoke(this, e);
    }
}

// Класс, представляющий термостат
class Thermostat
{
    //Метод для подписки термостата на событие изменения температуры датчика (вкл)
    public void SubscribeToTemperatureSensor(TemperatureSensor sensor)
    {
        sensor.TemperatureChanged += HandleTemperatureChanged;
    }
    //Метод для отписки термостата от события изменения температуры датчика (выкл)
    public void UnsubscribeFromTemperatureSensor(TemperatureSensor sensor)
    {
        sensor.TemperatureChanged -= HandleTemperatureChanged;
    }

    // Обработчик события изменения температуры,
    // который включает или выключает отопление в зависимости от измеренной температуры
    private void HandleTemperatureChanged(object sender, Temperature e)
    {
        //если температура меньше 20 гр., вкл отопление
        if (e.NewTemperature < 20)
        {
            Console.WriteLine("Отопление включено.");
        }
        //если больше выключать, либо неизменять
        else
        {
            Console.WriteLine("Отопление выключено.");
        }
    }
}

class tack5all
{
    static void Main()
    {
        TemperatureSensor sensor = new TemperatureSensor();
        Thermostat thermostat = new Thermostat();

        // Подписываем термостат на событие изменения температуры
        thermostat.SubscribeToTemperatureSensor(sensor);

        // Меняем температуру (генерируем событие)
        sensor.CurrentTemperature = 18.5;
        sensor.CurrentTemperature = 22.0;

        // Отписываем термостат от события
        thermostat.UnsubscribeFromTemperatureSensor(sensor);

        // Этот изменение температуры не вызовет реакции термостата, так как он отписан
        sensor.CurrentTemperature = 19.5;

        Console.ReadLine();
    }
}
