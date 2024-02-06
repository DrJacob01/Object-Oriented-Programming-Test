using System;
using System.Windows.Forms;

namespace OOP
{
    internal class Car
    {
        // Properties
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public float EngineSize { get; set; }

        // Constructor
        public Car(string make, string model, int year, float engineSize)
        {
            Make = make;
            Model = model;
            Year = year;
            EngineSize = engineSize;
        }

        // Method to display car information in a popup text box
        public void DisplayCarInfo()
        {
            string carInfo = $"Make: {Make}\nModel: {Model}\nYear: {Year}\nEngine Size: {EngineSize}L";
            MessageBox.Show(carInfo, "Car Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
